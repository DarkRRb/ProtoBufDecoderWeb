using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text.Json;
using NProtoBufDecoder;

namespace ProtoBufDecoderWeb.ViewModels;


public partial class MainViewModel {
    public JsonSerializerOptions Options { get; } = new() {
        WriteIndented = true,
    };

    public BehaviorSubject<string> Hex { get; } = new(string.Empty);

    public BehaviorSubject<bool> IsParsing { get; } = new(false);

    public IObservable<bool> ButtonIsEnabled { get; }

    public BehaviorSubject<IEnumerable<ProtoBufNode>> JsonResult { get; } = new([]);

    public MainViewModel(IObservable<bool> TextBoxHasErrors) {
        ButtonIsEnabled = TextBoxHasErrors.CombineLatest(IsParsing).Select(zip => !zip.First && !zip.Second);
    }
}