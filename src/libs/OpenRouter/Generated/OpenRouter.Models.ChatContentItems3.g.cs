#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatContentItems3 : global::System.IEquatable<ChatContentItems3>
    {
        /// <summary>
        /// Video input content part (legacy format - deprecated)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.LegacyChatContentVideo? LegacyChatContentVideo { get; init; }
#else
        public global::OpenRouter.LegacyChatContentVideo? LegacyChatContentVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyChatContentVideo))]
#endif
        public bool IsLegacyChatContentVideo => LegacyChatContentVideo != null;

        /// <summary>
        /// Video input content part
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentVideo? ChatContentVideo { get; init; }
#else
        public global::OpenRouter.ChatContentVideo? ChatContentVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentVideo))]
#endif
        public bool IsChatContentVideo => ChatContentVideo != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems3(global::OpenRouter.LegacyChatContentVideo value) => new ChatContentItems3((global::OpenRouter.LegacyChatContentVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.LegacyChatContentVideo?(ChatContentItems3 @this) => @this.LegacyChatContentVideo;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems3(global::OpenRouter.LegacyChatContentVideo? value)
        {
            LegacyChatContentVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems3(global::OpenRouter.ChatContentVideo value) => new ChatContentItems3((global::OpenRouter.ChatContentVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentVideo?(ChatContentItems3 @this) => @this.ChatContentVideo;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems3(global::OpenRouter.ChatContentVideo? value)
        {
            ChatContentVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems3(
            global::OpenRouter.LegacyChatContentVideo? legacyChatContentVideo,
            global::OpenRouter.ChatContentVideo? chatContentVideo
            )
        {
            LegacyChatContentVideo = legacyChatContentVideo;
            ChatContentVideo = chatContentVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatContentVideo as object ??
            LegacyChatContentVideo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LegacyChatContentVideo?.ToString() ??
            ChatContentVideo?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLegacyChatContentVideo && !IsChatContentVideo || !IsLegacyChatContentVideo && IsChatContentVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.LegacyChatContentVideo?, TResult>? legacyChatContentVideo = null,
            global::System.Func<global::OpenRouter.ChatContentVideo?, TResult>? chatContentVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLegacyChatContentVideo && legacyChatContentVideo != null)
            {
                return legacyChatContentVideo(LegacyChatContentVideo!);
            }
            else if (IsChatContentVideo && chatContentVideo != null)
            {
                return chatContentVideo(ChatContentVideo!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.LegacyChatContentVideo?>? legacyChatContentVideo = null,
            global::System.Action<global::OpenRouter.ChatContentVideo?>? chatContentVideo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLegacyChatContentVideo)
            {
                legacyChatContentVideo?.Invoke(LegacyChatContentVideo!);
            }
            else if (IsChatContentVideo)
            {
                chatContentVideo?.Invoke(ChatContentVideo!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LegacyChatContentVideo,
                typeof(global::OpenRouter.LegacyChatContentVideo),
                ChatContentVideo,
                typeof(global::OpenRouter.ChatContentVideo),
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
        public bool Equals(ChatContentItems3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LegacyChatContentVideo?>.Default.Equals(LegacyChatContentVideo, other.LegacyChatContentVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentVideo?>.Default.Equals(ChatContentVideo, other.ChatContentVideo) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentItems3 obj1, ChatContentItems3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentItems3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentItems3 obj1, ChatContentItems3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentItems3 o && Equals(o);
        }
    }
}
