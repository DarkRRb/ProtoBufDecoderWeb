using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Interactivity;
using Avalonia.NoAxaml;
using NProtoBufDecoder;
using ProtoBufDecoderWeb.Resources;
using ProtoBufDecoderWeb.Utilities;
using ProtoBufDecoderWeb.ViewModels;

namespace ProtoBufDecoderWeb.Views;

public class MainView : UserControl {
    private readonly TextBox _textBox;

    private readonly MainViewModel _vm;

    public MainView() {
        _textBox = new TextBox();

        _vm = new(_textBox.GetObservable(DataValidationErrors.HasErrorsProperty));

        Build();
    }

    private void Build() => this
        .Content(new Grid()
            .Margin(100)
            .ColumnDefinition(new(GridLength.Star))
            .ColumnDefinition(new(100, GridUnitType.Pixel))
            .RowDefinition(new(100, GridUnitType.Pixel))
            .RowDefinition(new(GridLength.Star))
            .Child(_textBox
                .Margin(0, 0, 10, 10)
                .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Stretch)
                .VerticalAlignment(Avalonia.Layout.VerticalAlignment.Stretch)
                .TextWrapping(Avalonia.Media.TextWrapping.Wrap)
                .OnTextChanged(TextBoxTextChangedHandler)
                .Text(_vm.Hex)
                .Column(0)
                .Row(0))
            .Child(new Button()
                .Margin(10, 0, 0, 10)
                .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Stretch)
                .VerticalAlignment(Avalonia.Layout.VerticalAlignment.Stretch)
                .HorizontalContentAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                .VerticalContentAlignment(Avalonia.Layout.VerticalAlignment.Center)
                .IsEnabled(_vm.ButtonIsEnabled)
                .OnClick(ButtonClickHandler)
                .Column(1)
                .Row(0)
                .Content(SR.Decode))
            .Child(new TreeView()
                .Margin(0, 10, 0, 0)
                .AutoScrollToSelectedItem(false)
                .Column(0)
                .Row(1)
                .ColumnSpan(2)
                .ItemsSource(_vm.JsonResult)
                .ItemTemplate(new FuncTreeDataTemplate<ProtoBufNode>(BuildTreeViewItem, TreeViewItemSelector))));

    private void TextBoxTextChangedHandler(object? sender, TextChangedEventArgs e) => Task.Run(() => {
        if (sender is not TextBox { Text: not null } box) return;

        _vm.Hex.OnNext(box.Text);

        if ((box.Text.Length & 0x01) == 1) {
            box.Error(SR.UnexpectedHexLength);
            return;
        }

        if (!box.Text.All(@char => @char.IsWithinClosedAny(('0', '9'), ('A', 'F'), ('a', 'f')))) {
            box.Error(SR.UnexpectedHexCharacters);
            return;
        }

        box.Error();
    });

    private void ButtonClickHandler(object? sender, RoutedEventArgs e) => Task.Run(() => {
        _vm.IsParsing.OnNext(true);
        try {
            string hex = _vm.Hex.Value;

            // fast!
            if (hex == "") {
                _vm.JsonResult.OnNext([]);
                return;
            }

            _vm.JsonResult.OnNext(ProtoBufDecoder.Decode(Convert.FromHexString(hex)).OrderBy(node => node.FieldNumber));
        } catch (Exception e) {
            _textBox.Error(e.Message);
        } finally {
            _vm.IsParsing.OnNext(false);
        }
    });

    private static TextBlock BuildTreeViewItem(ProtoBufNode node, INameScope _) => new TextBlock()
        .ContextMenu(new ContextMenu()
            .ItemsSource(node.CreateCopyMenuItems()))
        .Text(new StringBuilder()
            .AppendFormat("{0} {1} ", node.FieldNumber, node.WireType)
            .AppendProtoBufNode(node)
            .ToString());

    private static IEnumerable<ProtoBufNode> TreeViewItemSelector(ProtoBufNode node) {
        return node.TryAsMessage(out IEnumerable<ProtoBufNode>? sub)
            ? sub.OrderBy(node => node.FieldNumber)
            : Array.Empty<ProtoBufNode>();
    }
}