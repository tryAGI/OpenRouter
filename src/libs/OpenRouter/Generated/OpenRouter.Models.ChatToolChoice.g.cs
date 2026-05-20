#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool choice configuration
    /// </summary>
    public readonly partial struct ChatToolChoice : global::System.IEquatable<ChatToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolChoice0? ChatToolChoice0 { get; init; }
#else
        public global::OpenRouter.ChatToolChoice0? ChatToolChoice0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoice0))]
#endif
        public bool IsChatToolChoice0 => ChatToolChoice0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatToolChoice0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatToolChoice0? value)
        {
            value = ChatToolChoice0;
            return IsChatToolChoice0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatToolChoice0 PickChatToolChoice0() => IsChatToolChoice0
            ? ChatToolChoice0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolChoice0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolChoice1? ChatToolChoice1 { get; init; }
#else
        public global::OpenRouter.ChatToolChoice1? ChatToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoice1))]
#endif
        public bool IsChatToolChoice1 => ChatToolChoice1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatToolChoice1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatToolChoice1? value)
        {
            value = ChatToolChoice1;
            return IsChatToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatToolChoice1 PickChatToolChoice1() => IsChatToolChoice1
            ? ChatToolChoice1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolChoice1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolChoice2? ChatToolChoice2 { get; init; }
#else
        public global::OpenRouter.ChatToolChoice2? ChatToolChoice2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolChoice2))]
#endif
        public bool IsChatToolChoice2 => ChatToolChoice2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatToolChoice2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatToolChoice2? value)
        {
            value = ChatToolChoice2;
            return IsChatToolChoice2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatToolChoice2 PickChatToolChoice2() => IsChatToolChoice2
            ? ChatToolChoice2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatToolChoice2' but the value was {ToString()}.");

        /// <summary>
        /// Named tool choice for specific function
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatNamedToolChoice? ChatNamedToolChoice { get; init; }
#else
        public global::OpenRouter.ChatNamedToolChoice? ChatNamedToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatNamedToolChoice))]
#endif
        public bool IsChatNamedToolChoice => ChatNamedToolChoice != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatNamedToolChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatNamedToolChoice? value)
        {
            value = ChatNamedToolChoice;
            return IsChatNamedToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoice PickChatNamedToolChoice() => IsChatNamedToolChoice
            ? ChatNamedToolChoice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatNamedToolChoice' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter extension: force a specific server tool by naming it directly in `tool_choice.type` instead of wrapping it in `{ type: "function", function: { name } }`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatServerToolChoice? ChatServerToolChoice { get; init; }
#else
        public global::OpenRouter.ChatServerToolChoice? ChatServerToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatServerToolChoice))]
#endif
        public bool IsChatServerToolChoice => ChatServerToolChoice != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatServerToolChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatServerToolChoice? value)
        {
            value = ChatServerToolChoice;
            return IsChatServerToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatServerToolChoice PickChatServerToolChoice() => IsChatServerToolChoice
            ? ChatServerToolChoice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatServerToolChoice' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatToolChoice0 value) => new ChatToolChoice((global::OpenRouter.ChatToolChoice0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolChoice0?(ChatToolChoice @this) => @this.ChatToolChoice0;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatToolChoice0? value)
        {
            ChatToolChoice0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolChoice FromChatToolChoice0(global::OpenRouter.ChatToolChoice0? value) => new ChatToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatToolChoice1 value) => new ChatToolChoice((global::OpenRouter.ChatToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolChoice1?(ChatToolChoice @this) => @this.ChatToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatToolChoice1? value)
        {
            ChatToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolChoice FromChatToolChoice1(global::OpenRouter.ChatToolChoice1? value) => new ChatToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatToolChoice2 value) => new ChatToolChoice((global::OpenRouter.ChatToolChoice2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolChoice2?(ChatToolChoice @this) => @this.ChatToolChoice2;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatToolChoice2? value)
        {
            ChatToolChoice2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolChoice FromChatToolChoice2(global::OpenRouter.ChatToolChoice2? value) => new ChatToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatNamedToolChoice value) => new ChatToolChoice((global::OpenRouter.ChatNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatNamedToolChoice?(ChatToolChoice @this) => @this.ChatNamedToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatNamedToolChoice? value)
        {
            ChatNamedToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolChoice FromChatNamedToolChoice(global::OpenRouter.ChatNamedToolChoice? value) => new ChatToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatToolChoice(global::OpenRouter.ChatServerToolChoice value) => new ChatToolChoice((global::OpenRouter.ChatServerToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatServerToolChoice?(ChatToolChoice @this) => @this.ChatServerToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(global::OpenRouter.ChatServerToolChoice? value)
        {
            ChatServerToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatToolChoice FromChatServerToolChoice(global::OpenRouter.ChatServerToolChoice? value) => new ChatToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatToolChoice(
            global::OpenRouter.ChatToolChoice0? chatToolChoice0,
            global::OpenRouter.ChatToolChoice1? chatToolChoice1,
            global::OpenRouter.ChatToolChoice2? chatToolChoice2,
            global::OpenRouter.ChatNamedToolChoice? chatNamedToolChoice,
            global::OpenRouter.ChatServerToolChoice? chatServerToolChoice
            )
        {
            ChatToolChoice0 = chatToolChoice0;
            ChatToolChoice1 = chatToolChoice1;
            ChatToolChoice2 = chatToolChoice2;
            ChatNamedToolChoice = chatNamedToolChoice;
            ChatServerToolChoice = chatServerToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatServerToolChoice as object ??
            ChatNamedToolChoice as object ??
            ChatToolChoice2 as object ??
            ChatToolChoice1 as object ??
            ChatToolChoice0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatToolChoice0?.ToValueString() ??
            ChatToolChoice1?.ToValueString() ??
            ChatToolChoice2?.ToValueString() ??
            ChatNamedToolChoice?.ToString() ??
            ChatServerToolChoice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatToolChoice0 && !IsChatToolChoice1 && !IsChatToolChoice2 && !IsChatNamedToolChoice && !IsChatServerToolChoice || !IsChatToolChoice0 && IsChatToolChoice1 && !IsChatToolChoice2 && !IsChatNamedToolChoice && !IsChatServerToolChoice || !IsChatToolChoice0 && !IsChatToolChoice1 && IsChatToolChoice2 && !IsChatNamedToolChoice && !IsChatServerToolChoice || !IsChatToolChoice0 && !IsChatToolChoice1 && !IsChatToolChoice2 && IsChatNamedToolChoice && !IsChatServerToolChoice || !IsChatToolChoice0 && !IsChatToolChoice1 && !IsChatToolChoice2 && !IsChatNamedToolChoice && IsChatServerToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatToolChoice0?, TResult>? chatToolChoice0 = null,
            global::System.Func<global::OpenRouter.ChatToolChoice1?, TResult>? chatToolChoice1 = null,
            global::System.Func<global::OpenRouter.ChatToolChoice2?, TResult>? chatToolChoice2 = null,
            global::System.Func<global::OpenRouter.ChatNamedToolChoice, TResult>? chatNamedToolChoice = null,
            global::System.Func<global::OpenRouter.ChatServerToolChoice, TResult>? chatServerToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolChoice0 && chatToolChoice0 != null)
            {
                return chatToolChoice0(ChatToolChoice0!);
            }
            else if (IsChatToolChoice1 && chatToolChoice1 != null)
            {
                return chatToolChoice1(ChatToolChoice1!);
            }
            else if (IsChatToolChoice2 && chatToolChoice2 != null)
            {
                return chatToolChoice2(ChatToolChoice2!);
            }
            else if (IsChatNamedToolChoice && chatNamedToolChoice != null)
            {
                return chatNamedToolChoice(ChatNamedToolChoice!);
            }
            else if (IsChatServerToolChoice && chatServerToolChoice != null)
            {
                return chatServerToolChoice(ChatServerToolChoice!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatToolChoice0?>? chatToolChoice0 = null,

            global::System.Action<global::OpenRouter.ChatToolChoice1?>? chatToolChoice1 = null,

            global::System.Action<global::OpenRouter.ChatToolChoice2?>? chatToolChoice2 = null,

            global::System.Action<global::OpenRouter.ChatNamedToolChoice>? chatNamedToolChoice = null,

            global::System.Action<global::OpenRouter.ChatServerToolChoice>? chatServerToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolChoice0)
            {
                chatToolChoice0?.Invoke(ChatToolChoice0!);
            }
            else if (IsChatToolChoice1)
            {
                chatToolChoice1?.Invoke(ChatToolChoice1!);
            }
            else if (IsChatToolChoice2)
            {
                chatToolChoice2?.Invoke(ChatToolChoice2!);
            }
            else if (IsChatNamedToolChoice)
            {
                chatNamedToolChoice?.Invoke(ChatNamedToolChoice!);
            }
            else if (IsChatServerToolChoice)
            {
                chatServerToolChoice?.Invoke(ChatServerToolChoice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatToolChoice0?>? chatToolChoice0 = null,
            global::System.Action<global::OpenRouter.ChatToolChoice1?>? chatToolChoice1 = null,
            global::System.Action<global::OpenRouter.ChatToolChoice2?>? chatToolChoice2 = null,
            global::System.Action<global::OpenRouter.ChatNamedToolChoice>? chatNamedToolChoice = null,
            global::System.Action<global::OpenRouter.ChatServerToolChoice>? chatServerToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatToolChoice0)
            {
                chatToolChoice0?.Invoke(ChatToolChoice0!);
            }
            else if (IsChatToolChoice1)
            {
                chatToolChoice1?.Invoke(ChatToolChoice1!);
            }
            else if (IsChatToolChoice2)
            {
                chatToolChoice2?.Invoke(ChatToolChoice2!);
            }
            else if (IsChatNamedToolChoice)
            {
                chatNamedToolChoice?.Invoke(ChatNamedToolChoice!);
            }
            else if (IsChatServerToolChoice)
            {
                chatServerToolChoice?.Invoke(ChatServerToolChoice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatToolChoice0,
                typeof(global::OpenRouter.ChatToolChoice0),
                ChatToolChoice1,
                typeof(global::OpenRouter.ChatToolChoice1),
                ChatToolChoice2,
                typeof(global::OpenRouter.ChatToolChoice2),
                ChatNamedToolChoice,
                typeof(global::OpenRouter.ChatNamedToolChoice),
                ChatServerToolChoice,
                typeof(global::OpenRouter.ChatServerToolChoice),
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
        public bool Equals(ChatToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolChoice0?>.Default.Equals(ChatToolChoice0, other.ChatToolChoice0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolChoice1?>.Default.Equals(ChatToolChoice1, other.ChatToolChoice1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolChoice2?>.Default.Equals(ChatToolChoice2, other.ChatToolChoice2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatNamedToolChoice?>.Default.Equals(ChatNamedToolChoice, other.ChatNamedToolChoice) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatServerToolChoice?>.Default.Equals(ChatServerToolChoice, other.ChatServerToolChoice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatToolChoice obj1, ChatToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatToolChoice obj1, ChatToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatToolChoice o && Equals(o);
        }
    }
}
