#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StoredPromptTemplateVariables : global::System.IEquatable<StoredPromptTemplateVariables>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Text input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputText? InputText { get; init; }
#else
        public global::OpenRouter.InputText? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// Image input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputImage? InputImage { get; init; }
#else
        public global::OpenRouter.InputImage? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// File input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputFile? InputFile { get; init; }
#else
        public global::OpenRouter.InputFile? InputFile { get; }
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
        public static implicit operator StoredPromptTemplateVariables(string value) => new StoredPromptTemplateVariables((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StoredPromptTemplateVariables @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(global::OpenRouter.InputText value) => new StoredPromptTemplateVariables((global::OpenRouter.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputText?(StoredPromptTemplateVariables @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(global::OpenRouter.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(global::OpenRouter.InputImage value) => new StoredPromptTemplateVariables((global::OpenRouter.InputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputImage?(StoredPromptTemplateVariables @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(global::OpenRouter.InputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StoredPromptTemplateVariables(global::OpenRouter.InputFile value) => new StoredPromptTemplateVariables((global::OpenRouter.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputFile?(StoredPromptTemplateVariables @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(global::OpenRouter.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StoredPromptTemplateVariables(
            string? value1,
            global::OpenRouter.InputText? inputText,
            global::OpenRouter.InputImage? inputImage,
            global::OpenRouter.InputFile? inputFile
            )
        {
            Value1 = value1;
            InputText = inputText;
            InputImage = inputImage;
            InputFile = inputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFile as object ??
            InputImage as object ??
            InputText as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            InputText?.ToString() ??
            InputImage?.ToString() ??
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsInputText && !IsInputImage && !IsInputFile || !IsValue1 && IsInputText && !IsInputImage && !IsInputFile || !IsValue1 && !IsInputText && IsInputImage && !IsInputFile || !IsValue1 && !IsInputText && !IsInputImage && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::OpenRouter.InputText?, TResult>? inputText = null,
            global::System.Func<global::OpenRouter.InputImage?, TResult>? inputImage = null,
            global::System.Func<global::OpenRouter.InputFile?, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::OpenRouter.InputText?>? inputText = null,
            global::System.Action<global::OpenRouter.InputImage?>? inputImage = null,
            global::System.Action<global::OpenRouter.InputFile?>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                InputText,
                typeof(global::OpenRouter.InputText),
                InputImage,
                typeof(global::OpenRouter.InputImage),
                InputFile,
                typeof(global::OpenRouter.InputFile),
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
        public bool Equals(StoredPromptTemplateVariables other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputFile?>.Default.Equals(InputFile, other.InputFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StoredPromptTemplateVariables obj1, StoredPromptTemplateVariables obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StoredPromptTemplateVariables>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StoredPromptTemplateVariables obj1, StoredPromptTemplateVariables obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StoredPromptTemplateVariables o && Equals(o);
        }
    }
}
