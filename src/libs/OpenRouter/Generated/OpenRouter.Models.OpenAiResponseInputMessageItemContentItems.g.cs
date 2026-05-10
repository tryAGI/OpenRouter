#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAiResponseInputMessageItemContentItems : global::System.IEquatable<OpenAiResponseInputMessageItemContentItems>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// Audio input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? InputAudio { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1 PickInputAudio() => IsInputAudio
            ? InputAudio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudio' but the value was {ToString()}.");

        /// <summary>
        /// File input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? InputFile { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? InputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2 PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? InputImage { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3 PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? InputText { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4 PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1 value) => new OpenAiResponseInputMessageItemContentItems((global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1?(OpenAiResponseInputMessageItemContentItems @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItems FromInputAudio(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? value) => new OpenAiResponseInputMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2 value) => new OpenAiResponseInputMessageItemContentItems((global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2?(OpenAiResponseInputMessageItemContentItems @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItems FromInputFile(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? value) => new OpenAiResponseInputMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3 value) => new OpenAiResponseInputMessageItemContentItems((global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3?(OpenAiResponseInputMessageItemContentItems @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItems FromInputImage(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? value) => new OpenAiResponseInputMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4 value) => new OpenAiResponseInputMessageItemContentItems((global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4?(OpenAiResponseInputMessageItemContentItems @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemContentItems(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItems FromInputText(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? value) => new OpenAiResponseInputMessageItemContentItems(value);

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemContentItems(
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorType? type,
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? inputAudio,
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? inputFile,
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? inputImage,
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? inputText
            )
        {
            Type = type;

            InputAudio = inputAudio;
            InputFile = inputFile;
            InputImage = inputImage;
            InputText = inputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputText as object ??
            InputImage as object ??
            InputFile as object ??
            InputAudio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputAudio?.ToString() ??
            InputFile?.ToString() ??
            InputImage?.ToString() ??
            InputText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputAudio && !IsInputFile && !IsInputImage && !IsInputText || !IsInputAudio && IsInputFile && !IsInputImage && !IsInputText || !IsInputAudio && !IsInputFile && IsInputImage && !IsInputText || !IsInputAudio && !IsInputFile && !IsInputImage && IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2, TResult>? inputFile = null,
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3, TResult>? inputImage = null,
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4, TResult>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1>? inputAudio = null,

            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2>? inputFile = null,

            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3>? inputImage = null,

            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1>? inputAudio = null,
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2>? inputFile = null,
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3>? inputImage = null,
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputAudio,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1),
                InputFile,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2),
                InputImage,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3),
                InputText,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OpenAiResponseInputMessageItemContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4?>.Default.Equals(InputText, other.InputText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAiResponseInputMessageItemContentItems obj1, OpenAiResponseInputMessageItemContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAiResponseInputMessageItemContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAiResponseInputMessageItemContentItems obj1, OpenAiResponseInputMessageItemContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAiResponseInputMessageItemContentItems o && Equals(o);
        }
    }
}
