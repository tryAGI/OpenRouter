#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputMessageItemContentItems : global::System.IEquatable<InputMessageItemContentItems>
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
        public global::OpenRouter.InputMessageItemContentItems1? InputMessageItemContentItems1 { get; init; }
#else
        public global::OpenRouter.InputMessageItemContentItems1? InputMessageItemContentItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItemContentItems1))]
#endif
        public bool IsInputMessageItemContentItems1 => InputMessageItemContentItems1 != null;

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
        /// Audio input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputAudio? InputAudio { get; init; }
#else
        public global::OpenRouter.InputAudio? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// Video input content item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputVideo? InputVideo { get; init; }
#else
        public global::OpenRouter.InputVideo? InputVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputVideo))]
#endif
        public bool IsInputVideo => InputVideo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::OpenRouter.InputText value) => new InputMessageItemContentItems((global::OpenRouter.InputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputText?(InputMessageItemContentItems @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::OpenRouter.InputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::OpenRouter.InputMessageItemContentItems1 value) => new InputMessageItemContentItems((global::OpenRouter.InputMessageItemContentItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputMessageItemContentItems1?(InputMessageItemContentItems @this) => @this.InputMessageItemContentItems1;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::OpenRouter.InputMessageItemContentItems1? value)
        {
            InputMessageItemContentItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::OpenRouter.InputFile value) => new InputMessageItemContentItems((global::OpenRouter.InputFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputFile?(InputMessageItemContentItems @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::OpenRouter.InputFile? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::OpenRouter.InputAudio value) => new InputMessageItemContentItems((global::OpenRouter.InputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputAudio?(InputMessageItemContentItems @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::OpenRouter.InputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageItemContentItems(global::OpenRouter.InputVideo value) => new InputMessageItemContentItems((global::OpenRouter.InputVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputVideo?(InputMessageItemContentItems @this) => @this.InputVideo;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(global::OpenRouter.InputVideo? value)
        {
            InputVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMessageItemContentItems(
            global::OpenRouter.InputText? inputText,
            global::OpenRouter.InputMessageItemContentItems1? inputMessageItemContentItems1,
            global::OpenRouter.InputFile? inputFile,
            global::OpenRouter.InputAudio? inputAudio,
            global::OpenRouter.InputVideo? inputVideo
            )
        {
            InputText = inputText;
            InputMessageItemContentItems1 = inputMessageItemContentItems1;
            InputFile = inputFile;
            InputAudio = inputAudio;
            InputVideo = inputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputVideo as object ??
            InputAudio as object ??
            InputFile as object ??
            InputMessageItemContentItems1 as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputMessageItemContentItems1?.ToString() ??
            InputFile?.ToString() ??
            InputAudio?.ToString() ??
            InputVideo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputMessageItemContentItems1 && !IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && IsInputMessageItemContentItems1 && !IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && !IsInputMessageItemContentItems1 && IsInputFile && !IsInputAudio && !IsInputVideo || !IsInputText && !IsInputMessageItemContentItems1 && !IsInputFile && IsInputAudio && !IsInputVideo || !IsInputText && !IsInputMessageItemContentItems1 && !IsInputFile && !IsInputAudio && IsInputVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InputText?, TResult>? inputText = null,
            global::System.Func<global::OpenRouter.InputMessageItemContentItems1?, TResult>? inputMessageItemContentItems1 = null,
            global::System.Func<global::OpenRouter.InputFile?, TResult>? inputFile = null,
            global::System.Func<global::OpenRouter.InputAudio?, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.InputVideo?, TResult>? inputVideo = null,
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
            else if (IsInputMessageItemContentItems1 && inputMessageItemContentItems1 != null)
            {
                return inputMessageItemContentItems1(InputMessageItemContentItems1!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }
            else if (IsInputVideo && inputVideo != null)
            {
                return inputVideo(InputVideo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.InputText?>? inputText = null,
            global::System.Action<global::OpenRouter.InputMessageItemContentItems1?>? inputMessageItemContentItems1 = null,
            global::System.Action<global::OpenRouter.InputFile?>? inputFile = null,
            global::System.Action<global::OpenRouter.InputAudio?>? inputAudio = null,
            global::System.Action<global::OpenRouter.InputVideo?>? inputVideo = null,
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
            else if (IsInputMessageItemContentItems1)
            {
                inputMessageItemContentItems1?.Invoke(InputMessageItemContentItems1!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
            }
            else if (IsInputVideo)
            {
                inputVideo?.Invoke(InputVideo!);
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
                InputMessageItemContentItems1,
                typeof(global::OpenRouter.InputMessageItemContentItems1),
                InputFile,
                typeof(global::OpenRouter.InputFile),
                InputAudio,
                typeof(global::OpenRouter.InputAudio),
                InputVideo,
                typeof(global::OpenRouter.InputVideo),
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
        public bool Equals(InputMessageItemContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputMessageItemContentItems1?>.Default.Equals(InputMessageItemContentItems1, other.InputMessageItemContentItems1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputFile?>.Default.Equals(InputFile, other.InputFile) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputVideo?>.Default.Equals(InputVideo, other.InputVideo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputMessageItemContentItems obj1, InputMessageItemContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageItemContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputMessageItemContentItems obj1, InputMessageItemContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageItemContentItems o && Equals(o);
        }
    }
}
