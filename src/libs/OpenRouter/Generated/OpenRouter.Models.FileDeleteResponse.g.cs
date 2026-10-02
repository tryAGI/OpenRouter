#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Confirmation that a file was deleted, in the negotiated shape.<br/>
    /// Example: {"_shape":"openrouter","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","type":"file_deleted"}
    /// </summary>
    public readonly partial struct FileDeleteResponse : global::System.IEquatable<FileDeleteResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminatorShape? Shape { get; }

        /// <summary>
        /// Deletion result in the OpenRouter shape.<br/>
        /// Example: {"_shape":"openrouter","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","type":"file_deleted"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenRouterFileDeleted? Openrouter { get; init; }
#else
        public global::OpenRouter.OpenRouterFileDeleted? Openrouter { get; }
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
            out global::OpenRouter.OpenRouterFileDeleted? value)
        {
            value = Openrouter;
            return IsOpenrouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeleted PickOpenrouter() => Openrouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openrouter' but the value was {ToString()}.");

        /// <summary>
        /// Deletion result in OpenAI's shape.<br/>
        /// Example: {"_shape":"openai","deleted":true,"id":"or_file_011CNha8iCJcU1wXNR6q4V8w","object":"file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIFileDeleted? Openai { get; init; }
#else
        public global::OpenRouter.OpenAIFileDeleted? Openai { get; }
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
            out global::OpenRouter.OpenAIFileDeleted? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeleted PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        /// Deletion result in Anthropic's shape.<br/>
        /// Example: {"_shape":"anthropic","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","type":"file_deleted"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicFileDeleted? Anthropic { get; init; }
#else
        public global::OpenRouter.AnthropicFileDeleted? Anthropic { get; }
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
            out global::OpenRouter.AnthropicFileDeleted? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeleted PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileDeleteResponse(global::OpenRouter.OpenRouterFileDeleted value) => new FileDeleteResponse((global::OpenRouter.OpenRouterFileDeleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenRouterFileDeleted?(FileDeleteResponse @this) => @this.Openrouter;

        /// <summary>
        ///
        /// </summary>
        public FileDeleteResponse(global::OpenRouter.OpenRouterFileDeleted? value)
        {
            Openrouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileDeleteResponse FromOpenrouter(global::OpenRouter.OpenRouterFileDeleted? value) => new FileDeleteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileDeleteResponse(global::OpenRouter.OpenAIFileDeleted value) => new FileDeleteResponse((global::OpenRouter.OpenAIFileDeleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIFileDeleted?(FileDeleteResponse @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public FileDeleteResponse(global::OpenRouter.OpenAIFileDeleted? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileDeleteResponse FromOpenai(global::OpenRouter.OpenAIFileDeleted? value) => new FileDeleteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileDeleteResponse(global::OpenRouter.AnthropicFileDeleted value) => new FileDeleteResponse((global::OpenRouter.AnthropicFileDeleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicFileDeleted?(FileDeleteResponse @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public FileDeleteResponse(global::OpenRouter.AnthropicFileDeleted? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileDeleteResponse FromAnthropic(global::OpenRouter.AnthropicFileDeleted? value) => new FileDeleteResponse(value);

        /// <summary>
        ///
        /// </summary>
        public FileDeleteResponse(
            global::OpenRouter.FileDeleteResponseDiscriminatorShape? shape,
            global::OpenRouter.OpenRouterFileDeleted? openrouter,
            global::OpenRouter.OpenAIFileDeleted? openai,
            global::OpenRouter.AnthropicFileDeleted? anthropic
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
            global::System.Func<global::OpenRouter.OpenRouterFileDeleted, TResult>? openrouter = null,
            global::System.Func<global::OpenRouter.OpenAIFileDeleted, TResult>? openai = null,
            global::System.Func<global::OpenRouter.AnthropicFileDeleted, TResult>? anthropic = null,
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
            global::System.Action<global::OpenRouter.OpenRouterFileDeleted>? openrouter = null,

            global::System.Action<global::OpenRouter.OpenAIFileDeleted>? openai = null,

            global::System.Action<global::OpenRouter.AnthropicFileDeleted>? anthropic = null,
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
            global::System.Action<global::OpenRouter.OpenRouterFileDeleted>? openrouter = null,
            global::System.Action<global::OpenRouter.OpenAIFileDeleted>? openai = null,
            global::System.Action<global::OpenRouter.AnthropicFileDeleted>? anthropic = null,
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
                typeof(global::OpenRouter.OpenRouterFileDeleted),
                Openai,
                typeof(global::OpenRouter.OpenAIFileDeleted),
                Anthropic,
                typeof(global::OpenRouter.AnthropicFileDeleted),
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
        public bool Equals(FileDeleteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenRouterFileDeleted?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIFileDeleted?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicFileDeleted?>.Default.Equals(Anthropic, other.Anthropic)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FileDeleteResponse obj1, FileDeleteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileDeleteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FileDeleteResponse obj1, FileDeleteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileDeleteResponse o && Equals(o);
        }
    }
}
