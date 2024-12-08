namespace ProtoBufDecoderWeb.Resources {
    using System;
    using System.Resources;
    using System.Globalization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal SR() {
        }

        internal static ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("ProtoBufDecoderWeb.Resources.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string Decode {
            get {
                return ResourceManager.GetString("Decode", resourceCulture);
            }
        }

        internal static string UnexpectedHexLength {
            get {
                return ResourceManager.GetString("UnexpectedHexLength", resourceCulture);
            }
        }

        internal static string UnexpectedHexCharacters {
            get {
                return ResourceManager.GetString("UnexpectedHexCharacters", resourceCulture);
            }
        }

        internal static string CopyInt64 {
            get {
                return ResourceManager.GetString("CopyInt64", resourceCulture);
            }
        }

        internal static string CopyUint64 {
            get {
                return ResourceManager.GetString("CopyUint64", resourceCulture);
            }
        }

        internal static string CopySint64 {
            get {
                return ResourceManager.GetString("CopySint64", resourceCulture);
            }
        }

        internal static string CopyFixed64 {
            get {
                return ResourceManager.GetString("CopyFixed64", resourceCulture);
            }
        }

        internal static string CopySfixed64 {
            get {
                return ResourceManager.GetString("CopySfixed64", resourceCulture);
            }
        }

        internal static string CopyDouble {
            get {
                return ResourceManager.GetString("CopyDouble", resourceCulture);
            }
        }

        internal static string CopyString {
            get {
                return ResourceManager.GetString("CopyString", resourceCulture);
            }
        }

        internal static string CopyBytes {
            get {
                return ResourceManager.GetString("CopyBytes", resourceCulture);
            }
        }

        internal static string CopyFixed32 {
            get {
                return ResourceManager.GetString("CopyFixed32", resourceCulture);
            }
        }

        internal static string CopySfixed32 {
            get {
                return ResourceManager.GetString("CopySfixed32", resourceCulture);
            }
        }

        internal static string CopyFloat {
            get {
                return ResourceManager.GetString("CopyFloat", resourceCulture);
            }
        }

    }
}