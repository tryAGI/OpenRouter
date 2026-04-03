#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Content part for chat completion messages
    /// </summary>
    public readonly partial struct ChatContentItems : global::System.IEquatable<ChatContentItems>
    {
        /// <summary>
        /// Text content part
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentText? ChatContentText { get; init; }
#else
        public global::OpenRouter.ChatContentText? ChatContentText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentText))]
#endif
        public bool IsChatContentText => ChatContentText != null;

        /// <summary>
        /// Image content part for vision models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentImage? ChatContentImage { get; init; }
#else
        public global::OpenRouter.ChatContentImage? ChatContentImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentImage))]
#endif
        public bool IsChatContentImage => ChatContentImage != null;

        /// <summary>
        /// Audio input content part. Supported audio formats vary by provider.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentAudio? ChatContentAudio { get; init; }
#else
        public global::OpenRouter.ChatContentAudio? ChatContentAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentAudio))]
#endif
        public bool IsChatContentAudio => ChatContentAudio != null;

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
        /// File content part for document processing
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentFile? ChatContentFile { get; init; }
#else
        public global::OpenRouter.ChatContentFile? ChatContentFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatContentFile))]
#endif
        public bool IsChatContentFile => ChatContentFile != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentText value) => new ChatContentItems((global::OpenRouter.ChatContentText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentText?(ChatContentItems @this) => @this.ChatContentText;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentText? value)
        {
            ChatContentText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentImage value) => new ChatContentItems((global::OpenRouter.ChatContentImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentImage?(ChatContentItems @this) => @this.ChatContentImage;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentImage? value)
        {
            ChatContentImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentAudio value) => new ChatContentItems((global::OpenRouter.ChatContentAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentAudio?(ChatContentItems @this) => @this.ChatContentAudio;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentAudio? value)
        {
            ChatContentAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.LegacyChatContentVideo value) => new ChatContentItems((global::OpenRouter.LegacyChatContentVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.LegacyChatContentVideo?(ChatContentItems @this) => @this.LegacyChatContentVideo;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.LegacyChatContentVideo? value)
        {
            LegacyChatContentVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentVideo value) => new ChatContentItems((global::OpenRouter.ChatContentVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentVideo?(ChatContentItems @this) => @this.ChatContentVideo;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentVideo? value)
        {
            ChatContentVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentFile value) => new ChatContentItems((global::OpenRouter.ChatContentFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentFile?(ChatContentItems @this) => @this.ChatContentFile;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentFile? value)
        {
            ChatContentFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(
            global::OpenRouter.ChatContentText? chatContentText,
            global::OpenRouter.ChatContentImage? chatContentImage,
            global::OpenRouter.ChatContentAudio? chatContentAudio,
            global::OpenRouter.LegacyChatContentVideo? legacyChatContentVideo,
            global::OpenRouter.ChatContentVideo? chatContentVideo,
            global::OpenRouter.ChatContentFile? chatContentFile
            )
        {
            ChatContentText = chatContentText;
            ChatContentImage = chatContentImage;
            ChatContentAudio = chatContentAudio;
            LegacyChatContentVideo = legacyChatContentVideo;
            ChatContentVideo = chatContentVideo;
            ChatContentFile = chatContentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatContentFile as object ??
            ChatContentVideo as object ??
            LegacyChatContentVideo as object ??
            ChatContentAudio as object ??
            ChatContentImage as object ??
            ChatContentText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatContentText?.ToString() ??
            ChatContentImage?.ToString() ??
            ChatContentAudio?.ToString() ??
            LegacyChatContentVideo?.ToString() ??
            ChatContentVideo?.ToString() ??
            ChatContentFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatContentText && !IsChatContentImage && !IsChatContentAudio && !IsLegacyChatContentVideo && !IsChatContentVideo && !IsChatContentFile || !IsChatContentText && IsChatContentImage && !IsChatContentAudio && !IsLegacyChatContentVideo && !IsChatContentVideo && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && IsChatContentAudio && !IsLegacyChatContentVideo && !IsChatContentVideo && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && !IsChatContentAudio && IsLegacyChatContentVideo && !IsChatContentVideo && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && !IsChatContentAudio && !IsLegacyChatContentVideo && IsChatContentVideo && !IsChatContentFile || !IsChatContentText && !IsChatContentImage && !IsChatContentAudio && !IsLegacyChatContentVideo && !IsChatContentVideo && IsChatContentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatContentText?, TResult>? chatContentText = null,
            global::System.Func<global::OpenRouter.ChatContentImage?, TResult>? chatContentImage = null,
            global::System.Func<global::OpenRouter.ChatContentAudio?, TResult>? chatContentAudio = null,
            global::System.Func<global::OpenRouter.LegacyChatContentVideo?, TResult>? legacyChatContentVideo = null,
            global::System.Func<global::OpenRouter.ChatContentVideo?, TResult>? chatContentVideo = null,
            global::System.Func<global::OpenRouter.ChatContentFile?, TResult>? chatContentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatContentText && chatContentText != null)
            {
                return chatContentText(ChatContentText!);
            }
            else if (IsChatContentImage && chatContentImage != null)
            {
                return chatContentImage(ChatContentImage!);
            }
            else if (IsChatContentAudio && chatContentAudio != null)
            {
                return chatContentAudio(ChatContentAudio!);
            }
            else if (IsLegacyChatContentVideo && legacyChatContentVideo != null)
            {
                return legacyChatContentVideo(LegacyChatContentVideo!);
            }
            else if (IsChatContentVideo && chatContentVideo != null)
            {
                return chatContentVideo(ChatContentVideo!);
            }
            else if (IsChatContentFile && chatContentFile != null)
            {
                return chatContentFile(ChatContentFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatContentText?>? chatContentText = null,
            global::System.Action<global::OpenRouter.ChatContentImage?>? chatContentImage = null,
            global::System.Action<global::OpenRouter.ChatContentAudio?>? chatContentAudio = null,
            global::System.Action<global::OpenRouter.LegacyChatContentVideo?>? legacyChatContentVideo = null,
            global::System.Action<global::OpenRouter.ChatContentVideo?>? chatContentVideo = null,
            global::System.Action<global::OpenRouter.ChatContentFile?>? chatContentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatContentText)
            {
                chatContentText?.Invoke(ChatContentText!);
            }
            else if (IsChatContentImage)
            {
                chatContentImage?.Invoke(ChatContentImage!);
            }
            else if (IsChatContentAudio)
            {
                chatContentAudio?.Invoke(ChatContentAudio!);
            }
            else if (IsLegacyChatContentVideo)
            {
                legacyChatContentVideo?.Invoke(LegacyChatContentVideo!);
            }
            else if (IsChatContentVideo)
            {
                chatContentVideo?.Invoke(ChatContentVideo!);
            }
            else if (IsChatContentFile)
            {
                chatContentFile?.Invoke(ChatContentFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatContentText,
                typeof(global::OpenRouter.ChatContentText),
                ChatContentImage,
                typeof(global::OpenRouter.ChatContentImage),
                ChatContentAudio,
                typeof(global::OpenRouter.ChatContentAudio),
                LegacyChatContentVideo,
                typeof(global::OpenRouter.LegacyChatContentVideo),
                ChatContentVideo,
                typeof(global::OpenRouter.ChatContentVideo),
                ChatContentFile,
                typeof(global::OpenRouter.ChatContentFile),
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
        public bool Equals(ChatContentItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentText?>.Default.Equals(ChatContentText, other.ChatContentText) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentImage?>.Default.Equals(ChatContentImage, other.ChatContentImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentAudio?>.Default.Equals(ChatContentAudio, other.ChatContentAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LegacyChatContentVideo?>.Default.Equals(LegacyChatContentVideo, other.LegacyChatContentVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentVideo?>.Default.Equals(ChatContentVideo, other.ChatContentVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentFile?>.Default.Equals(ChatContentFile, other.ChatContentFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContentItems obj1, ChatContentItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContentItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContentItems obj1, ChatContentItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentItems o && Equals(o);
        }
    }
}
