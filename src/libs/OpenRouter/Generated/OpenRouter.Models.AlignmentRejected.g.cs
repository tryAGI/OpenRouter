#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlignmentRejected : global::System.IEquatable<AlignmentRejected>
    {
        /// <summary>
        /// The assistant message of the withheld turn, without reasoning. `audio` holds the id and transcript of the audio, without `data` or `expires_at`.<br/>
        /// Example: {"content":"Sure, I can take 20% off your order.","refusal":null,"role":"assistant"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AlignmentChatRejected? Chat { get; init; }
#else
        public global::OpenRouter.AlignmentChatRejected? Chat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AlignmentChatRejected? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatRejected PickChat() => Chat is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");

        /// <summary>
        /// The output items of the withheld turn, without reasoning items. The client did not receive these items; their `id` values are assigned by the plugin (`msg_&lt;turn id&gt;`, `fc_&lt;call_id&gt;`, `ctc_&lt;call_id&gt;`, `ig_&lt;turn id&gt;_&lt;index&gt;`, or the provider item id of a native tool call) and differ from the ids the Responses API assigns to delivered items.<br/>
        /// Example: [{"content":[{"annotations":[],"text":"Sure, I can take 20% off your order.","type":"output_text"}],"id":"msg_1","role":"assistant","status":"completed","type":"message"}]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>? Responses { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>? Responses { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Responses))]
#endif
        public bool IsResponses => Responses != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>? value)
        {
            value = Responses;
            return IsResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem> PickResponses() => Responses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Responses' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlignmentRejected(global::OpenRouter.AlignmentChatRejected value) => new AlignmentRejected((global::OpenRouter.AlignmentChatRejected?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AlignmentChatRejected?(AlignmentRejected @this) => @this.Chat;

        /// <summary>
        ///
        /// </summary>
        public AlignmentRejected(global::OpenRouter.AlignmentChatRejected? value)
        {
            Chat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlignmentRejected FromChat(global::OpenRouter.AlignmentChatRejected? value) => new AlignmentRejected(value);

        /// <summary>
        ///
        /// </summary>
        public AlignmentRejected(
            global::OpenRouter.AlignmentChatRejected? chat,
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>? responses
            )
        {
            Chat = chat;
            Responses = responses;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Responses as object ??
            Chat as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            Responses?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChat || IsResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AlignmentChatRejected, TResult>? chat = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>, TResult>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chat is { } __value0 && chat != null)
            {
                return chat(__value0);
            }
            else if (Responses is { } __value1 && responses != null)
            {
                return responses(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AlignmentChatRejected>? chat = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chat is { } __value0)
            {
                chat?.Invoke(__value0);
            }
            else if (Responses is { } __value1)
            {
                responses?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AlignmentChatRejected>? chat = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Chat is { } __value0)
            {
                chat?.Invoke(__value0);
            }
            else if (Responses is { } __value1)
            {
                responses?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::OpenRouter.AlignmentChatRejected),
                Responses,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>),
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
        public bool Equals(AlignmentRejected other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AlignmentChatRejected?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>?>.Default.Equals(Responses, other.Responses)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AlignmentRejected obj1, AlignmentRejected obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AlignmentRejected>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlignmentRejected obj1, AlignmentRejected obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlignmentRejected o && Equals(o);
        }
    }
}
