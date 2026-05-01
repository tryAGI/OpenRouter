#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items : global::System.IEquatable<BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>
    {
        /// <summary>
        /// Audio input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1? InputAudio { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// File input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2? InputFile { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2? InputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3? InputImage { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4? InputText { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4? InputText { get; }
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
        public static implicit operator BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1 value) => new BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items((global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1?(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2 value) => new BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items((global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2?(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3 value) => new BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items((global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3?(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4 value) => new BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items((global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4?(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1? inputAudio,
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2? inputFile,
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3? inputImage,
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4? inputText
            )
        {
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
            global::System.Func<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1?, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2?, TResult>? inputFile = null,
            global::System.Func<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3?, TResult>? inputImage = null,
            global::System.Func<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4?, TResult>? inputText = null,
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
            global::System.Action<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1?>? inputAudio = null,
            global::System.Action<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2?>? inputFile = null,
            global::System.Action<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3?>? inputImage = null,
            global::System.Action<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4?>? inputText = null,
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
                typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1),
                InputFile,
                typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2),
                InputImage,
                typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3),
                InputText,
                typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4),
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
        public bool Equals(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4?>.Default.Equals(InputText, other.InputText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items obj1, BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items obj1, BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items o && Equals(o);
        }
    }
}
