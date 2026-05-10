#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionCallOutputItemOutputOneOf1Items : global::System.IEquatable<FunctionCallOutputItemOutputOneOf1Items>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// File input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1? InputFile { get; init; }
#else
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1? InputFile { get; }
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
            out global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2? InputImage { get; init; }
#else
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2? InputImage { get; }
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
            out global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3? InputText { get; init; }
#else
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3? InputText { get; }
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
            out global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3? value)
        {
            value = InputText;
            return IsInputText;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1 value) => new FunctionCallOutputItemOutputOneOf1Items((global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2 value) => new FunctionCallOutputItemOutputOneOf1Items((global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3 value) => new FunctionCallOutputItemOutputOneOf1Items((global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(
            global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType? type,
            global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1? inputFile,
            global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2? inputImage,
            global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3? inputText
            )
        {
            Type = type;

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
            InputFile as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputFile?.ToString() ??
            InputImage?.ToString() ??
            InputText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputFile && !IsInputImage && !IsInputText || !IsInputFile && IsInputImage && !IsInputText || !IsInputFile && !IsInputImage && IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1, TResult>? inputFile = null,
            global::System.Func<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2, TResult>? inputImage = null,
            global::System.Func<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3, TResult>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputFile && inputFile != null)
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
            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1>? inputFile = null,

            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2>? inputImage = null,

            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputFile)
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
            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1>? inputFile = null,
            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2>? inputImage = null,
            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputFile)
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
                InputFile,
                typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1),
                InputImage,
                typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2),
                InputText,
                typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3),
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
        public bool Equals(FunctionCallOutputItemOutputOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3?>.Default.Equals(InputText, other.InputText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionCallOutputItemOutputOneOf1Items obj1, FunctionCallOutputItemOutputOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallOutputItemOutputOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionCallOutputItemOutputOneOf1Items obj1, FunctionCallOutputItemOutputOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallOutputItemOutputOneOf1Items o && Equals(o);
        }
    }
}
