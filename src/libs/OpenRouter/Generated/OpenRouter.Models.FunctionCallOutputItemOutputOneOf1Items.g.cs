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
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1? FunctionCallOutputItemOutputOneOf1Items1 { get; init; }
#else
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1? FunctionCallOutputItemOutputOneOf1Items1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItemOutputOneOf1Items1))]
#endif
        public bool IsFunctionCallOutputItemOutputOneOf1Items1 => FunctionCallOutputItemOutputOneOf1Items1 != null;

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
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.InputText value) => new FunctionCallOutputItemOutputOneOf1Items((global::OpenRouter.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputText?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1 value) => new FunctionCallOutputItemOutputOneOf1Items((global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.FunctionCallOutputItemOutputOneOf1Items1;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1? value)
        {
            FunctionCallOutputItemOutputOneOf1Items1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.InputFile value) => new FunctionCallOutputItemOutputOneOf1Items((global::OpenRouter.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputFile?(FunctionCallOutputItemOutputOneOf1Items @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(global::OpenRouter.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1Items(
            global::OpenRouter.InputText? inputText,
            global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1? functionCallOutputItemOutputOneOf1Items1,
            global::OpenRouter.InputFile? inputFile
            )
        {
            InputText = inputText;
            FunctionCallOutputItemOutputOneOf1Items1 = functionCallOutputItemOutputOneOf1Items1;
            InputFile = inputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFile as object ??
            FunctionCallOutputItemOutputOneOf1Items1 as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            FunctionCallOutputItemOutputOneOf1Items1?.ToString() ??
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsFunctionCallOutputItemOutputOneOf1Items1 && !IsInputFile || !IsInputText && IsFunctionCallOutputItemOutputOneOf1Items1 && !IsInputFile || !IsInputText && !IsFunctionCallOutputItemOutputOneOf1Items1 && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InputText?, TResult>? inputText = null,
            global::System.Func<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1?, TResult>? functionCallOutputItemOutputOneOf1Items1 = null,
            global::System.Func<global::OpenRouter.InputFile?, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsFunctionCallOutputItemOutputOneOf1Items1 && functionCallOutputItemOutputOneOf1Items1 != null)
            {
                return functionCallOutputItemOutputOneOf1Items1(FunctionCallOutputItemOutputOneOf1Items1!);
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
            global::System.Action<global::OpenRouter.InputText?>? inputText = null,
            global::System.Action<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1?>? functionCallOutputItemOutputOneOf1Items1 = null,
            global::System.Action<global::OpenRouter.InputFile?>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsFunctionCallOutputItemOutputOneOf1Items1)
            {
                functionCallOutputItemOutputOneOf1Items1?.Invoke(FunctionCallOutputItemOutputOneOf1Items1!);
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
                InputText,
                typeof(global::OpenRouter.InputText),
                FunctionCallOutputItemOutputOneOf1Items1,
                typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1),
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
        public bool Equals(FunctionCallOutputItemOutputOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1?>.Default.Equals(FunctionCallOutputItemOutputOneOf1Items1, other.FunctionCallOutputItemOutputOneOf1Items1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputFile?>.Default.Equals(InputFile, other.InputFile) 
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
