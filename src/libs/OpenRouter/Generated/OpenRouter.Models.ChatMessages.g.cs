#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion message with role-based discrimination
    /// </summary>
    public readonly partial struct ChatMessages : global::System.IEquatable<ChatMessages>
    {
        /// <summary>
        /// System message for setting behavior
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatSystemMessage? ChatSystemMessage { get; init; }
#else
        public global::OpenRouter.ChatSystemMessage? ChatSystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatSystemMessage))]
#endif
        public bool IsChatSystemMessage => ChatSystemMessage != null;

        /// <summary>
        /// User message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatUserMessage? ChatUserMessage { get; init; }
#else
        public global::OpenRouter.ChatUserMessage? ChatUserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatUserMessage))]
#endif
        public bool IsChatUserMessage => ChatUserMessage != null;

        /// <summary>
        /// Developer message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatDeveloperMessage? ChatDeveloperMessage { get; init; }
#else
        public global::OpenRouter.ChatDeveloperMessage? ChatDeveloperMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatDeveloperMessage))]
#endif
        public bool IsChatDeveloperMessage => ChatDeveloperMessage != null;

        /// <summary>
        /// Assistant message for requests and responses
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatAssistantMessage? ChatAssistantMessage { get; init; }
#else
        public global::OpenRouter.ChatAssistantMessage? ChatAssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatAssistantMessage))]
#endif
        public bool IsChatAssistantMessage => ChatAssistantMessage != null;

        /// <summary>
        /// Tool response message
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatToolMessage? ChatToolMessage { get; init; }
#else
        public global::OpenRouter.ChatToolMessage? ChatToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatToolMessage))]
#endif
        public bool IsChatToolMessage => ChatToolMessage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatSystemMessage value) => new ChatMessages((global::OpenRouter.ChatSystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatSystemMessage?(ChatMessages @this) => @this.ChatSystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatSystemMessage? value)
        {
            ChatSystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatUserMessage value) => new ChatMessages((global::OpenRouter.ChatUserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatUserMessage?(ChatMessages @this) => @this.ChatUserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatUserMessage? value)
        {
            ChatUserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatDeveloperMessage value) => new ChatMessages((global::OpenRouter.ChatDeveloperMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatDeveloperMessage?(ChatMessages @this) => @this.ChatDeveloperMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatDeveloperMessage? value)
        {
            ChatDeveloperMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatAssistantMessage value) => new ChatMessages((global::OpenRouter.ChatAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatAssistantMessage?(ChatMessages @this) => @this.ChatAssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatAssistantMessage? value)
        {
            ChatAssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessages(global::OpenRouter.ChatToolMessage value) => new ChatMessages((global::OpenRouter.ChatToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatToolMessage?(ChatMessages @this) => @this.ChatToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(global::OpenRouter.ChatToolMessage? value)
        {
            ChatToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessages(
            global::OpenRouter.ChatSystemMessage? chatSystemMessage,
            global::OpenRouter.ChatUserMessage? chatUserMessage,
            global::OpenRouter.ChatDeveloperMessage? chatDeveloperMessage,
            global::OpenRouter.ChatAssistantMessage? chatAssistantMessage,
            global::OpenRouter.ChatToolMessage? chatToolMessage
            )
        {
            ChatSystemMessage = chatSystemMessage;
            ChatUserMessage = chatUserMessage;
            ChatDeveloperMessage = chatDeveloperMessage;
            ChatAssistantMessage = chatAssistantMessage;
            ChatToolMessage = chatToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatToolMessage as object ??
            ChatAssistantMessage as object ??
            ChatDeveloperMessage as object ??
            ChatUserMessage as object ??
            ChatSystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatSystemMessage?.ToString() ??
            ChatUserMessage?.ToString() ??
            ChatDeveloperMessage?.ToString() ??
            ChatAssistantMessage?.ToString() ??
            ChatToolMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatSystemMessage && !IsChatUserMessage && !IsChatDeveloperMessage && !IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && IsChatUserMessage && !IsChatDeveloperMessage && !IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && !IsChatUserMessage && IsChatDeveloperMessage && !IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && !IsChatUserMessage && !IsChatDeveloperMessage && IsChatAssistantMessage && !IsChatToolMessage || !IsChatSystemMessage && !IsChatUserMessage && !IsChatDeveloperMessage && !IsChatAssistantMessage && IsChatToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatSystemMessage?, TResult>? chatSystemMessage = null,
            global::System.Func<global::OpenRouter.ChatUserMessage?, TResult>? chatUserMessage = null,
            global::System.Func<global::OpenRouter.ChatDeveloperMessage?, TResult>? chatDeveloperMessage = null,
            global::System.Func<global::OpenRouter.ChatAssistantMessage?, TResult>? chatAssistantMessage = null,
            global::System.Func<global::OpenRouter.ChatToolMessage?, TResult>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatSystemMessage && chatSystemMessage != null)
            {
                return chatSystemMessage(ChatSystemMessage!);
            }
            else if (IsChatUserMessage && chatUserMessage != null)
            {
                return chatUserMessage(ChatUserMessage!);
            }
            else if (IsChatDeveloperMessage && chatDeveloperMessage != null)
            {
                return chatDeveloperMessage(ChatDeveloperMessage!);
            }
            else if (IsChatAssistantMessage && chatAssistantMessage != null)
            {
                return chatAssistantMessage(ChatAssistantMessage!);
            }
            else if (IsChatToolMessage && chatToolMessage != null)
            {
                return chatToolMessage(ChatToolMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatSystemMessage?>? chatSystemMessage = null,
            global::System.Action<global::OpenRouter.ChatUserMessage?>? chatUserMessage = null,
            global::System.Action<global::OpenRouter.ChatDeveloperMessage?>? chatDeveloperMessage = null,
            global::System.Action<global::OpenRouter.ChatAssistantMessage?>? chatAssistantMessage = null,
            global::System.Action<global::OpenRouter.ChatToolMessage?>? chatToolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatSystemMessage)
            {
                chatSystemMessage?.Invoke(ChatSystemMessage!);
            }
            else if (IsChatUserMessage)
            {
                chatUserMessage?.Invoke(ChatUserMessage!);
            }
            else if (IsChatDeveloperMessage)
            {
                chatDeveloperMessage?.Invoke(ChatDeveloperMessage!);
            }
            else if (IsChatAssistantMessage)
            {
                chatAssistantMessage?.Invoke(ChatAssistantMessage!);
            }
            else if (IsChatToolMessage)
            {
                chatToolMessage?.Invoke(ChatToolMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatSystemMessage,
                typeof(global::OpenRouter.ChatSystemMessage),
                ChatUserMessage,
                typeof(global::OpenRouter.ChatUserMessage),
                ChatDeveloperMessage,
                typeof(global::OpenRouter.ChatDeveloperMessage),
                ChatAssistantMessage,
                typeof(global::OpenRouter.ChatAssistantMessage),
                ChatToolMessage,
                typeof(global::OpenRouter.ChatToolMessage),
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
        public bool Equals(ChatMessages other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatSystemMessage?>.Default.Equals(ChatSystemMessage, other.ChatSystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatUserMessage?>.Default.Equals(ChatUserMessage, other.ChatUserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatDeveloperMessage?>.Default.Equals(ChatDeveloperMessage, other.ChatDeveloperMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatAssistantMessage?>.Default.Equals(ChatAssistantMessage, other.ChatAssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatToolMessage?>.Default.Equals(ChatToolMessage, other.ChatToolMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessages obj1, ChatMessages obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessages>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessages obj1, ChatMessages obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessages o && Equals(o);
        }
    }
}
