#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Developer message content
    /// </summary>
    public readonly partial struct ChatMessagesDiscriminatorMappingDeveloperContent : global::System.IEquatable<ChatMessagesDiscriminatorMappingDeveloperContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatMessagesDiscriminatorMappingDeveloperContentVariant1 { get; init; }
#else
        public string? ChatMessagesDiscriminatorMappingDeveloperContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessagesDiscriminatorMappingDeveloperContentVariant1))]
#endif
        public bool IsChatMessagesDiscriminatorMappingDeveloperContentVariant1 => ChatMessagesDiscriminatorMappingDeveloperContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatMessagesDiscriminatorMappingDeveloperContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ChatMessagesDiscriminatorMappingDeveloperContentVariant1;
            return IsChatMessagesDiscriminatorMappingDeveloperContentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickChatMessagesDiscriminatorMappingDeveloperContentVariant1() => IsChatMessagesDiscriminatorMappingDeveloperContentVariant1
            ? ChatMessagesDiscriminatorMappingDeveloperContentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessagesDiscriminatorMappingDeveloperContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? ChatMessagesDiscriminatorMappingDeveloperContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? ChatMessagesDiscriminatorMappingDeveloperContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessagesDiscriminatorMappingDeveloperContent1))]
#endif
        public bool IsChatMessagesDiscriminatorMappingDeveloperContent1 => ChatMessagesDiscriminatorMappingDeveloperContent1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatMessagesDiscriminatorMappingDeveloperContent1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? value)
        {
            value = ChatMessagesDiscriminatorMappingDeveloperContent1;
            return IsChatMessagesDiscriminatorMappingDeveloperContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText> PickChatMessagesDiscriminatorMappingDeveloperContent1() => IsChatMessagesDiscriminatorMappingDeveloperContent1
            ? ChatMessagesDiscriminatorMappingDeveloperContent1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessagesDiscriminatorMappingDeveloperContent1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessagesDiscriminatorMappingDeveloperContent(string value) => new ChatMessagesDiscriminatorMappingDeveloperContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatMessagesDiscriminatorMappingDeveloperContent @this) => @this.ChatMessagesDiscriminatorMappingDeveloperContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessagesDiscriminatorMappingDeveloperContent(string? value)
        {
            ChatMessagesDiscriminatorMappingDeveloperContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatMessagesDiscriminatorMappingDeveloperContent FromChatMessagesDiscriminatorMappingDeveloperContentVariant1(string? value) => new ChatMessagesDiscriminatorMappingDeveloperContent(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatMessagesDiscriminatorMappingDeveloperContent(
            string? chatMessagesDiscriminatorMappingDeveloperContentVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? chatMessagesDiscriminatorMappingDeveloperContent1
            )
        {
            ChatMessagesDiscriminatorMappingDeveloperContentVariant1 = chatMessagesDiscriminatorMappingDeveloperContentVariant1;
            ChatMessagesDiscriminatorMappingDeveloperContent1 = chatMessagesDiscriminatorMappingDeveloperContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatMessagesDiscriminatorMappingDeveloperContent1 as object ??
            ChatMessagesDiscriminatorMappingDeveloperContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatMessagesDiscriminatorMappingDeveloperContentVariant1?.ToString() ??
            ChatMessagesDiscriminatorMappingDeveloperContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatMessagesDiscriminatorMappingDeveloperContentVariant1 && !IsChatMessagesDiscriminatorMappingDeveloperContent1 || !IsChatMessagesDiscriminatorMappingDeveloperContentVariant1 && IsChatMessagesDiscriminatorMappingDeveloperContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? chatMessagesDiscriminatorMappingDeveloperContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>, TResult>? chatMessagesDiscriminatorMappingDeveloperContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessagesDiscriminatorMappingDeveloperContentVariant1 && chatMessagesDiscriminatorMappingDeveloperContentVariant1 != null)
            {
                return chatMessagesDiscriminatorMappingDeveloperContentVariant1(ChatMessagesDiscriminatorMappingDeveloperContentVariant1!);
            }
            else if (IsChatMessagesDiscriminatorMappingDeveloperContent1 && chatMessagesDiscriminatorMappingDeveloperContent1 != null)
            {
                return chatMessagesDiscriminatorMappingDeveloperContent1(ChatMessagesDiscriminatorMappingDeveloperContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? chatMessagesDiscriminatorMappingDeveloperContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>? chatMessagesDiscriminatorMappingDeveloperContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessagesDiscriminatorMappingDeveloperContentVariant1)
            {
                chatMessagesDiscriminatorMappingDeveloperContentVariant1?.Invoke(ChatMessagesDiscriminatorMappingDeveloperContentVariant1!);
            }
            else if (IsChatMessagesDiscriminatorMappingDeveloperContent1)
            {
                chatMessagesDiscriminatorMappingDeveloperContent1?.Invoke(ChatMessagesDiscriminatorMappingDeveloperContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? chatMessagesDiscriminatorMappingDeveloperContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>? chatMessagesDiscriminatorMappingDeveloperContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatMessagesDiscriminatorMappingDeveloperContentVariant1)
            {
                chatMessagesDiscriminatorMappingDeveloperContentVariant1?.Invoke(ChatMessagesDiscriminatorMappingDeveloperContentVariant1!);
            }
            else if (IsChatMessagesDiscriminatorMappingDeveloperContent1)
            {
                chatMessagesDiscriminatorMappingDeveloperContent1?.Invoke(ChatMessagesDiscriminatorMappingDeveloperContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatMessagesDiscriminatorMappingDeveloperContentVariant1,
                typeof(string),
                ChatMessagesDiscriminatorMappingDeveloperContent1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>),
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
        public bool Equals(ChatMessagesDiscriminatorMappingDeveloperContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatMessagesDiscriminatorMappingDeveloperContentVariant1, other.ChatMessagesDiscriminatorMappingDeveloperContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>?>.Default.Equals(ChatMessagesDiscriminatorMappingDeveloperContent1, other.ChatMessagesDiscriminatorMappingDeveloperContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessagesDiscriminatorMappingDeveloperContent obj1, ChatMessagesDiscriminatorMappingDeveloperContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessagesDiscriminatorMappingDeveloperContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessagesDiscriminatorMappingDeveloperContent obj1, ChatMessagesDiscriminatorMappingDeveloperContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessagesDiscriminatorMappingDeveloperContent o && Equals(o);
        }
    }
}
