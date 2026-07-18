#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Assistant message content
    /// </summary>
    public readonly partial struct ChatMessagesDiscriminatorMappingAssistantContent : global::System.IEquatable<ChatMessagesDiscriminatorMappingAssistantContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatMessagesDiscriminatorMappingAssistantContentVariant1 { get; init; }
#else
        public string? ChatMessagesDiscriminatorMappingAssistantContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessagesDiscriminatorMappingAssistantContentVariant1))]
#endif
        public bool IsChatMessagesDiscriminatorMappingAssistantContentVariant1 => ChatMessagesDiscriminatorMappingAssistantContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatMessagesDiscriminatorMappingAssistantContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChatMessagesDiscriminatorMappingAssistantContentVariant1;
            return IsChatMessagesDiscriminatorMappingAssistantContentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickChatMessagesDiscriminatorMappingAssistantContentVariant1() => IsChatMessagesDiscriminatorMappingAssistantContentVariant1
            ? ChatMessagesDiscriminatorMappingAssistantContentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessagesDiscriminatorMappingAssistantContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? ChatMessagesDiscriminatorMappingAssistantContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? ChatMessagesDiscriminatorMappingAssistantContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessagesDiscriminatorMappingAssistantContent1))]
#endif
        public bool IsChatMessagesDiscriminatorMappingAssistantContent1 => ChatMessagesDiscriminatorMappingAssistantContent1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatMessagesDiscriminatorMappingAssistantContent1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? value)
        {
            value = ChatMessagesDiscriminatorMappingAssistantContent1;
            return IsChatMessagesDiscriminatorMappingAssistantContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems> PickChatMessagesDiscriminatorMappingAssistantContent1() => IsChatMessagesDiscriminatorMappingAssistantContent1
            ? ChatMessagesDiscriminatorMappingAssistantContent1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessagesDiscriminatorMappingAssistantContent1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessagesDiscriminatorMappingAssistantContent(string value) => new ChatMessagesDiscriminatorMappingAssistantContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatMessagesDiscriminatorMappingAssistantContent @this) => @this.ChatMessagesDiscriminatorMappingAssistantContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessagesDiscriminatorMappingAssistantContent(string? value)
        {
            ChatMessagesDiscriminatorMappingAssistantContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessagesDiscriminatorMappingAssistantContent FromChatMessagesDiscriminatorMappingAssistantContentVariant1(string? value) => new ChatMessagesDiscriminatorMappingAssistantContent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatMessagesDiscriminatorMappingAssistantContent(
            string? chatMessagesDiscriminatorMappingAssistantContentVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? chatMessagesDiscriminatorMappingAssistantContent1
            )
        {
            ChatMessagesDiscriminatorMappingAssistantContentVariant1 = chatMessagesDiscriminatorMappingAssistantContentVariant1;
            ChatMessagesDiscriminatorMappingAssistantContent1 = chatMessagesDiscriminatorMappingAssistantContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatMessagesDiscriminatorMappingAssistantContent1 as object ??
            ChatMessagesDiscriminatorMappingAssistantContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatMessagesDiscriminatorMappingAssistantContentVariant1?.ToString() ??
            ChatMessagesDiscriminatorMappingAssistantContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatMessagesDiscriminatorMappingAssistantContentVariant1 && !IsChatMessagesDiscriminatorMappingAssistantContent1 || !IsChatMessagesDiscriminatorMappingAssistantContentVariant1 && IsChatMessagesDiscriminatorMappingAssistantContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? chatMessagesDiscriminatorMappingAssistantContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>, TResult>? chatMessagesDiscriminatorMappingAssistantContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessagesDiscriminatorMappingAssistantContentVariant1 && chatMessagesDiscriminatorMappingAssistantContentVariant1 != null)
            {
                return chatMessagesDiscriminatorMappingAssistantContentVariant1(ChatMessagesDiscriminatorMappingAssistantContentVariant1!);
            }
            else if (IsChatMessagesDiscriminatorMappingAssistantContent1 && chatMessagesDiscriminatorMappingAssistantContent1 != null)
            {
                return chatMessagesDiscriminatorMappingAssistantContent1(ChatMessagesDiscriminatorMappingAssistantContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? chatMessagesDiscriminatorMappingAssistantContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? chatMessagesDiscriminatorMappingAssistantContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessagesDiscriminatorMappingAssistantContentVariant1)
            {
                chatMessagesDiscriminatorMappingAssistantContentVariant1?.Invoke(ChatMessagesDiscriminatorMappingAssistantContentVariant1!);
            }
            else if (IsChatMessagesDiscriminatorMappingAssistantContent1)
            {
                chatMessagesDiscriminatorMappingAssistantContent1?.Invoke(ChatMessagesDiscriminatorMappingAssistantContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? chatMessagesDiscriminatorMappingAssistantContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? chatMessagesDiscriminatorMappingAssistantContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessagesDiscriminatorMappingAssistantContentVariant1)
            {
                chatMessagesDiscriminatorMappingAssistantContentVariant1?.Invoke(ChatMessagesDiscriminatorMappingAssistantContentVariant1!);
            }
            else if (IsChatMessagesDiscriminatorMappingAssistantContent1)
            {
                chatMessagesDiscriminatorMappingAssistantContent1?.Invoke(ChatMessagesDiscriminatorMappingAssistantContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatMessagesDiscriminatorMappingAssistantContentVariant1,
                typeof(string),
                ChatMessagesDiscriminatorMappingAssistantContent1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>),
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
        public bool Equals(ChatMessagesDiscriminatorMappingAssistantContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatMessagesDiscriminatorMappingAssistantContentVariant1, other.ChatMessagesDiscriminatorMappingAssistantContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>?>.Default.Equals(ChatMessagesDiscriminatorMappingAssistantContent1, other.ChatMessagesDiscriminatorMappingAssistantContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessagesDiscriminatorMappingAssistantContent obj1, ChatMessagesDiscriminatorMappingAssistantContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessagesDiscriminatorMappingAssistantContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessagesDiscriminatorMappingAssistantContent obj1, ChatMessagesDiscriminatorMappingAssistantContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessagesDiscriminatorMappingAssistantContent o && Equals(o);
        }
    }
}
