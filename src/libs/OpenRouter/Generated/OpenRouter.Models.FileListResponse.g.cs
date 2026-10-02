#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A page of files, in the negotiated shape.<br/>
    /// Example: {"_shape":"openrouter","cursor":null,"data":[],"first_id":null,"has_more":false,"last_id":null}
    /// </summary>
    public readonly partial struct FileListResponse : global::System.IEquatable<FileListResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminatorShape? Shape { get; }

        /// <summary>
        /// A page of files in the OpenRouter shape.<br/>
        /// Example: {"_shape":"openrouter","cursor":null,"data":[],"first_id":null,"has_more":false,"last_id":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenRouterFileList? Openrouter { get; init; }
#else
        public global::OpenRouter.OpenRouterFileList? Openrouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openrouter))]
#endif
        public bool IsOpenrouter => Openrouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenRouterFileList? value)
        {
            value = Openrouter;
            return IsOpenrouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileList PickOpenrouter() => Openrouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openrouter' but the value was {ToString()}.");

        /// <summary>
        /// A page of files in OpenAI's shape.<br/>
        /// Example: {"_shape":"openai","data":[],"first_id":null,"has_more":false,"last_id":null,"object":"list"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIFileList? Openai { get; init; }
#else
        public global::OpenRouter.OpenAIFileList? Openai { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIFileList? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileList PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        /// A page of files in Anthropic's shape.<br/>
        /// Example: {"_shape":"anthropic","data":[],"first_id":null,"has_more":false,"last_id":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicFileList? Anthropic { get; init; }
#else
        public global::OpenRouter.AnthropicFileList? Anthropic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicFileList? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileList PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileListResponse(global::OpenRouter.OpenRouterFileList value) => new FileListResponse((global::OpenRouter.OpenRouterFileList?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenRouterFileList?(FileListResponse @this) => @this.Openrouter;

        /// <summary>
        ///
        /// </summary>
        public FileListResponse(global::OpenRouter.OpenRouterFileList? value)
        {
            Openrouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileListResponse FromOpenrouter(global::OpenRouter.OpenRouterFileList? value) => new FileListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileListResponse(global::OpenRouter.OpenAIFileList value) => new FileListResponse((global::OpenRouter.OpenAIFileList?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIFileList?(FileListResponse @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public FileListResponse(global::OpenRouter.OpenAIFileList? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileListResponse FromOpenai(global::OpenRouter.OpenAIFileList? value) => new FileListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileListResponse(global::OpenRouter.AnthropicFileList value) => new FileListResponse((global::OpenRouter.AnthropicFileList?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicFileList?(FileListResponse @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public FileListResponse(global::OpenRouter.AnthropicFileList? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileListResponse FromAnthropic(global::OpenRouter.AnthropicFileList? value) => new FileListResponse(value);

        /// <summary>
        ///
        /// </summary>
        public FileListResponse(
            global::OpenRouter.FileListResponseDiscriminatorShape? shape,
            global::OpenRouter.OpenRouterFileList? openrouter,
            global::OpenRouter.OpenAIFileList? openai,
            global::OpenRouter.AnthropicFileList? anthropic
            )
        {
            Shape = shape;

            Openrouter = openrouter;
            Openai = openai;
            Anthropic = anthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Anthropic as object ??
            Openai as object ??
            Openrouter as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Openrouter?.ToString() ??
            Openai?.ToString() ??
            Anthropic?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenrouter && !IsOpenai && !IsAnthropic || !IsOpenrouter && IsOpenai && !IsAnthropic || !IsOpenrouter && !IsOpenai && IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenRouterFileList, TResult>? openrouter = null,
            global::System.Func<global::OpenRouter.OpenAIFileList, TResult>? openai = null,
            global::System.Func<global::OpenRouter.AnthropicFileList, TResult>? anthropic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Openrouter is { } __value0 && openrouter != null)
            {
                return openrouter(__value0);
            }
            else if (Openai is { } __value1 && openai != null)
            {
                return openai(__value1);
            }
            else if (Anthropic is { } __value2 && anthropic != null)
            {
                return anthropic(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenRouterFileList>? openrouter = null,

            global::System.Action<global::OpenRouter.OpenAIFileList>? openai = null,

            global::System.Action<global::OpenRouter.AnthropicFileList>? anthropic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Openrouter is { } __value0)
            {
                openrouter?.Invoke(__value0);
            }
            else if (Openai is { } __value1)
            {
                openai?.Invoke(__value1);
            }
            else if (Anthropic is { } __value2)
            {
                anthropic?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenRouterFileList>? openrouter = null,
            global::System.Action<global::OpenRouter.OpenAIFileList>? openai = null,
            global::System.Action<global::OpenRouter.AnthropicFileList>? anthropic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Openrouter is { } __value0)
            {
                openrouter?.Invoke(__value0);
            }
            else if (Openai is { } __value1)
            {
                openai?.Invoke(__value1);
            }
            else if (Anthropic is { } __value2)
            {
                anthropic?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Openrouter,
                typeof(global::OpenRouter.OpenRouterFileList),
                Openai,
                typeof(global::OpenRouter.OpenAIFileList),
                Anthropic,
                typeof(global::OpenRouter.AnthropicFileList),
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
        public bool Equals(FileListResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenRouterFileList?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIFileList?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicFileList?>.Default.Equals(Anthropic, other.Anthropic)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FileListResponse obj1, FileListResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileListResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FileListResponse obj1, FileListResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileListResponse o && Equals(o);
        }
    }
}
