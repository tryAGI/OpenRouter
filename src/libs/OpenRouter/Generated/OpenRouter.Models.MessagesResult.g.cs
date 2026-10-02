#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Non-streaming response from the Anthropic Messages API with OpenRouter extensions<br/>
    /// Example: {"container":null,"content":[{"citations":[],"text":"Hello! I\u0027m doing well, thank you for asking.","type":"text"}],"id":"msg_01XFDUDYJgAACzvnptvVoYEL","model":"claude-sonnet-4-5-20250929","role":"assistant","stop_details":null,"stop_reason":"end_turn","stop_sequence":null,"type":"message","usage":{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":12,"output_tokens":15,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}}
    /// </summary>
    public readonly partial struct MessagesResult : global::System.IEquatable<MessagesResult>
    {
        /// <summary>
        /// Base Anthropic Messages API response before OpenRouter extensions<br/>
        /// Example: {"container":null,"content":[{"citations":[],"text":"Hello!","type":"text"}],"id":"msg_01XFDUDYJgAACzvnptvVoYEL","model":"claude-sonnet-4-5-20250929","role":"assistant","stop_details":null,"stop_reason":"end_turn","stop_sequence":null,"type":"message","usage":{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":12,"output_tokens":8,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseMessagesResult? Base { get; init; }
#else
        public global::OpenRouter.BaseMessagesResult? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BaseMessagesResult? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResult PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesResultVariant2? MessagesResultVariant2 { get; init; }
#else
        public global::OpenRouter.MessagesResultVariant2? MessagesResultVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesResultVariant2))]
#endif
        public bool IsMessagesResultVariant2 => MessagesResultVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessagesResultVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesResultVariant2? value)
        {
            value = MessagesResultVariant2;
            return IsMessagesResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2 PickMessagesResultVariant2() => MessagesResultVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesResultVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesResult(global::OpenRouter.BaseMessagesResult value) => new MessagesResult((global::OpenRouter.BaseMessagesResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseMessagesResult?(MessagesResult @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public MessagesResult(global::OpenRouter.BaseMessagesResult? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesResult FromBase(global::OpenRouter.BaseMessagesResult? value) => new MessagesResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesResult(global::OpenRouter.MessagesResultVariant2 value) => new MessagesResult((global::OpenRouter.MessagesResultVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesResultVariant2?(MessagesResult @this) => @this.MessagesResultVariant2;

        /// <summary>
        ///
        /// </summary>
        public MessagesResult(global::OpenRouter.MessagesResultVariant2? value)
        {
            MessagesResultVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesResult FromMessagesResultVariant2(global::OpenRouter.MessagesResultVariant2? value) => new MessagesResult(value);

        /// <summary>
        ///
        /// </summary>
        public MessagesResult(
            global::OpenRouter.BaseMessagesResult? @base,
            global::OpenRouter.MessagesResultVariant2? messagesResultVariant2
            )
        {
            Base = @base;
            MessagesResultVariant2 = messagesResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MessagesResultVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            MessagesResultVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMessagesResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseMessagesResult, TResult>? @base = null,
            global::System.Func<global::OpenRouter.MessagesResultVariant2, TResult>? messagesResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (MessagesResultVariant2 is { } __value1 && messagesResultVariant2 != null)
            {
                return messagesResultVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseMessagesResult>? @base = null,

            global::System.Action<global::OpenRouter.MessagesResultVariant2>? messagesResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (MessagesResultVariant2 is { } __value1)
            {
                messagesResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseMessagesResult>? @base = null,
            global::System.Action<global::OpenRouter.MessagesResultVariant2>? messagesResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (MessagesResultVariant2 is { } __value1)
            {
                messagesResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::OpenRouter.BaseMessagesResult),
                MessagesResultVariant2,
                typeof(global::OpenRouter.MessagesResultVariant2),
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
        public bool Equals(MessagesResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseMessagesResult?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesResultVariant2?>.Default.Equals(MessagesResultVariant2, other.MessagesResultVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MessagesResult obj1, MessagesResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesResult obj1, MessagesResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesResult o && Equals(o);
        }
    }
}
