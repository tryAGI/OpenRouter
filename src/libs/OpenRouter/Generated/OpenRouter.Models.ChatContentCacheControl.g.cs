#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Anthropic-style cache breakpoint for the content part. Interchangeable with the OpenAI-style `prompt_cache_breakpoint` marker: OpenRouter converts between the two based on the provider serving the request.<br/>
    /// Example: {"ttl":"5m","type":"ephemeral"}
    /// </summary>
    public readonly partial struct ChatContentCacheControl : global::System.IEquatable<ChatContentCacheControl>
    {
        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCacheControlDirective? AnthropicDirective { get; init; }
#else
        public global::OpenRouter.AnthropicCacheControlDirective? AnthropicDirective { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicDirective))]
#endif
        public bool IsAnthropicDirective => AnthropicDirective != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicDirective(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCacheControlDirective? value)
        {
            value = AnthropicDirective;
            return IsAnthropicDirective;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirective PickAnthropicDirective() => AnthropicDirective is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicDirective' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ChatContentCacheControlVariant2 { get; init; }
#else
        public object? ChatContentCacheControlVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentCacheControlVariant2))]
#endif
        public bool IsChatContentCacheControlVariant2 => ChatContentCacheControlVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatContentCacheControlVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ChatContentCacheControlVariant2;
            return IsChatContentCacheControlVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickChatContentCacheControlVariant2() => ChatContentCacheControlVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatContentCacheControlVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentCacheControl(global::OpenRouter.AnthropicCacheControlDirective value) => new ChatContentCacheControl((global::OpenRouter.AnthropicCacheControlDirective?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCacheControlDirective?(ChatContentCacheControl @this) => @this.AnthropicDirective;

        /// <summary>
        ///
        /// </summary>
        public ChatContentCacheControl(global::OpenRouter.AnthropicCacheControlDirective? value)
        {
            AnthropicDirective = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentCacheControl FromAnthropicDirective(global::OpenRouter.AnthropicCacheControlDirective? value) => new ChatContentCacheControl(value);

        /// <summary>
        ///
        /// </summary>
        public ChatContentCacheControl(
            global::OpenRouter.AnthropicCacheControlDirective? anthropicDirective,
            object? chatContentCacheControlVariant2
            )
        {
            AnthropicDirective = anthropicDirective;
            ChatContentCacheControlVariant2 = chatContentCacheControlVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChatContentCacheControlVariant2 as object ??
            AnthropicDirective as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AnthropicDirective?.ToString() ??
            ChatContentCacheControlVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicDirective && IsChatContentCacheControlVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCacheControlDirective, TResult>? anthropicDirective = null,
            global::System.Func<object, TResult>? chatContentCacheControlVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicDirective is { } __value0 && anthropicDirective != null)
            {
                return anthropicDirective(__value0);
            }
            else if (ChatContentCacheControlVariant2 is { } __value1 && chatContentCacheControlVariant2 != null)
            {
                return chatContentCacheControlVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCacheControlDirective>? anthropicDirective = null,

            global::System.Action<object>? chatContentCacheControlVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicDirective is { } __value0)
            {
                anthropicDirective?.Invoke(__value0);
            }
            else if (ChatContentCacheControlVariant2 is { } __value1)
            {
                chatContentCacheControlVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicCacheControlDirective>? anthropicDirective = null,
            global::System.Action<object>? chatContentCacheControlVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicDirective is { } __value0)
            {
                anthropicDirective?.Invoke(__value0);
            }
            else if (ChatContentCacheControlVariant2 is { } __value1)
            {
                chatContentCacheControlVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicDirective,
                typeof(global::OpenRouter.AnthropicCacheControlDirective),
                ChatContentCacheControlVariant2,
                typeof(object),
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
        public bool Equals(ChatContentCacheControl other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCacheControlDirective?>.Default.Equals(AnthropicDirective, other.AnthropicDirective) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ChatContentCacheControlVariant2, other.ChatContentCacheControlVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChatContentCacheControl obj1, ChatContentCacheControl obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentCacheControl>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatContentCacheControl obj1, ChatContentCacheControl obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentCacheControl o && Equals(o);
        }
    }
}
