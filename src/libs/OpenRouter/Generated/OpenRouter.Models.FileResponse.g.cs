#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A stored file. The shape is negotiated per request — see the endpoint description.<br/>
    /// Example: {"_shape":"openrouter","created_at":"2025-01-01T00:00:00Z","downloadable":false,"filename":"document.pdf","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","mime_type":"application/pdf","size_bytes":1024000,"type":"file"}
    /// </summary>
    public readonly partial struct FileResponse : global::System.IEquatable<FileResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminatorShape? Shape { get; }

        /// <summary>
        /// A stored file in the OpenRouter superset shape: Anthropic-shaped, plus OpenRouter-only fields.<br/>
        /// Example: {"_shape":"openrouter","created_at":"2025-01-01T00:00:00Z","downloadable":false,"filename":"document.pdf","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","mime_type":"application/pdf","size_bytes":1024000,"type":"file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenRouterFile? Openrouter { get; init; }
#else
        public global::OpenRouter.OpenRouterFile? Openrouter { get; }
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
            out global::OpenRouter.OpenRouterFile? value)
        {
            value = Openrouter;
            return IsOpenrouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFile PickOpenrouter() => Openrouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openrouter' but the value was {ToString()}.");

        /// <summary>
        /// A stored file in OpenAI's Files API shape.<br/>
        /// Example: {"_shape":"openai","bytes":1024000,"created_at":1735689600,"filename":"document.pdf","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","object":"file","purpose":"user_data","status":"processed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIFile? Openai { get; init; }
#else
        public global::OpenRouter.OpenAIFile? Openai { get; }
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
            out global::OpenRouter.OpenAIFile? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFile PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

        /// <summary>
        /// A stored file in Anthropic's Files API shape.<br/>
        /// Example: {"_shape":"anthropic","created_at":"2025-01-01T00:00:00Z","downloadable":false,"filename":"document.pdf","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","mime_type":"application/pdf","size_bytes":1024000,"type":"file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicFile? Anthropic { get; init; }
#else
        public global::OpenRouter.AnthropicFile? Anthropic { get; }
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
            out global::OpenRouter.AnthropicFile? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFile PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileResponse(global::OpenRouter.OpenRouterFile value) => new FileResponse((global::OpenRouter.OpenRouterFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenRouterFile?(FileResponse @this) => @this.Openrouter;

        /// <summary>
        ///
        /// </summary>
        public FileResponse(global::OpenRouter.OpenRouterFile? value)
        {
            Openrouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileResponse FromOpenrouter(global::OpenRouter.OpenRouterFile? value) => new FileResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileResponse(global::OpenRouter.OpenAIFile value) => new FileResponse((global::OpenRouter.OpenAIFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIFile?(FileResponse @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public FileResponse(global::OpenRouter.OpenAIFile? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileResponse FromOpenai(global::OpenRouter.OpenAIFile? value) => new FileResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FileResponse(global::OpenRouter.AnthropicFile value) => new FileResponse((global::OpenRouter.AnthropicFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicFile?(FileResponse @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public FileResponse(global::OpenRouter.AnthropicFile? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FileResponse FromAnthropic(global::OpenRouter.AnthropicFile? value) => new FileResponse(value);

        /// <summary>
        ///
        /// </summary>
        public FileResponse(
            global::OpenRouter.FileResponseDiscriminatorShape? shape,
            global::OpenRouter.OpenRouterFile? openrouter,
            global::OpenRouter.OpenAIFile? openai,
            global::OpenRouter.AnthropicFile? anthropic
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
            global::System.Func<global::OpenRouter.OpenRouterFile, TResult>? openrouter = null,
            global::System.Func<global::OpenRouter.OpenAIFile, TResult>? openai = null,
            global::System.Func<global::OpenRouter.AnthropicFile, TResult>? anthropic = null,
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
            global::System.Action<global::OpenRouter.OpenRouterFile>? openrouter = null,

            global::System.Action<global::OpenRouter.OpenAIFile>? openai = null,

            global::System.Action<global::OpenRouter.AnthropicFile>? anthropic = null,
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
            global::System.Action<global::OpenRouter.OpenRouterFile>? openrouter = null,
            global::System.Action<global::OpenRouter.OpenAIFile>? openai = null,
            global::System.Action<global::OpenRouter.AnthropicFile>? anthropic = null,
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
                typeof(global::OpenRouter.OpenRouterFile),
                Openai,
                typeof(global::OpenRouter.OpenAIFile),
                Anthropic,
                typeof(global::OpenRouter.AnthropicFile),
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
        public bool Equals(FileResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenRouterFile?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIFile?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicFile?>.Default.Equals(Anthropic, other.Anthropic)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FileResponse obj1, FileResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FileResponse obj1, FileResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileResponse o && Equals(o);
        }
    }
}
