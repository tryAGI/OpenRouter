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
        /// File content part for document processing
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentItemsVariant1? File { get; init; }
#else
        public global::OpenRouter.ChatContentItemsVariant1? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentItemsVariant1? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        /// Image content part for vision models
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentItemsVariant2? ImageUrl { get; init; }
#else
        public global::OpenRouter.ChatContentItemsVariant2? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentItemsVariant2? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        /// Audio input content part. Supported audio formats vary by provider.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentItemsVariant3? InputAudio { get; init; }
#else
        public global::OpenRouter.ChatContentItemsVariant3? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentItemsVariant3? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        /// Video input content part (legacy format - deprecated)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentItemsVariant4? InputVideo { get; init; }
#else
        public global::OpenRouter.ChatContentItemsVariant4? InputVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputVideo))]
#endif
        public bool IsInputVideo => InputVideo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentItemsVariant4? value)
        {
            value = InputVideo;
            return IsInputVideo;
        }

        /// <summary>
        /// Text content part
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentItemsVariant5? Text { get; init; }
#else
        public global::OpenRouter.ChatContentItemsVariant5? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentItemsVariant5? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// Video input content part
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentItemsVariant6? VideoUrl { get; init; }
#else
        public global::OpenRouter.ChatContentItemsVariant6? VideoUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUrl))]
#endif
        public bool IsVideoUrl => VideoUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentItemsVariant6? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentItemsVariant1 value) => new ChatContentItems((global::OpenRouter.ChatContentItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentItemsVariant1?(ChatContentItems @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentItemsVariant1? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentItemsVariant2 value) => new ChatContentItems((global::OpenRouter.ChatContentItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentItemsVariant2?(ChatContentItems @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentItemsVariant2? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentItemsVariant3 value) => new ChatContentItems((global::OpenRouter.ChatContentItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentItemsVariant3?(ChatContentItems @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentItemsVariant3? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentItemsVariant4 value) => new ChatContentItems((global::OpenRouter.ChatContentItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentItemsVariant4?(ChatContentItems @this) => @this.InputVideo;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentItemsVariant4? value)
        {
            InputVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentItemsVariant5 value) => new ChatContentItems((global::OpenRouter.ChatContentItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentItemsVariant5?(ChatContentItems @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentItemsVariant5? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentItemsVariant6 value) => new ChatContentItems((global::OpenRouter.ChatContentItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentItemsVariant6?(ChatContentItems @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentItemsVariant6? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatContentItems(
            global::OpenRouter.ChatContentItemsVariant1? file,
            global::OpenRouter.ChatContentItemsVariant2? imageUrl,
            global::OpenRouter.ChatContentItemsVariant3? inputAudio,
            global::OpenRouter.ChatContentItemsVariant4? inputVideo,
            global::OpenRouter.ChatContentItemsVariant5? text,
            global::OpenRouter.ChatContentItemsVariant6? videoUrl
            )
        {
            File = file;
            ImageUrl = imageUrl;
            InputAudio = inputAudio;
            InputVideo = inputVideo;
            Text = text;
            VideoUrl = videoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            Text as object ??
            InputVideo as object ??
            InputAudio as object ??
            ImageUrl as object ??
            File as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            ImageUrl?.ToString() ??
            InputAudio?.ToString() ??
            InputVideo?.ToString() ??
            Text?.ToString() ??
            VideoUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFile && !IsImageUrl && !IsInputAudio && !IsInputVideo && !IsText && !IsVideoUrl || !IsFile && IsImageUrl && !IsInputAudio && !IsInputVideo && !IsText && !IsVideoUrl || !IsFile && !IsImageUrl && IsInputAudio && !IsInputVideo && !IsText && !IsVideoUrl || !IsFile && !IsImageUrl && !IsInputAudio && IsInputVideo && !IsText && !IsVideoUrl || !IsFile && !IsImageUrl && !IsInputAudio && !IsInputVideo && IsText && !IsVideoUrl || !IsFile && !IsImageUrl && !IsInputAudio && !IsInputVideo && !IsText && IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatContentItemsVariant1, TResult>? file = null,
            global::System.Func<global::OpenRouter.ChatContentItemsVariant2, TResult>? imageUrl = null,
            global::System.Func<global::OpenRouter.ChatContentItemsVariant3, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.ChatContentItemsVariant4, TResult>? inputVideo = null,
            global::System.Func<global::OpenRouter.ChatContentItemsVariant5, TResult>? text = null,
            global::System.Func<global::OpenRouter.ChatContentItemsVariant6, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }
            else if (IsInputVideo && inputVideo != null)
            {
                return inputVideo(InputVideo!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsVideoUrl && videoUrl != null)
            {
                return videoUrl(VideoUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatContentItemsVariant1>? file = null,

            global::System.Action<global::OpenRouter.ChatContentItemsVariant2>? imageUrl = null,

            global::System.Action<global::OpenRouter.ChatContentItemsVariant3>? inputAudio = null,

            global::System.Action<global::OpenRouter.ChatContentItemsVariant4>? inputVideo = null,

            global::System.Action<global::OpenRouter.ChatContentItemsVariant5>? text = null,

            global::System.Action<global::OpenRouter.ChatContentItemsVariant6>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
            }
            else if (IsInputVideo)
            {
                inputVideo?.Invoke(InputVideo!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsVideoUrl)
            {
                videoUrl?.Invoke(VideoUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatContentItemsVariant1>? file = null,
            global::System.Action<global::OpenRouter.ChatContentItemsVariant2>? imageUrl = null,
            global::System.Action<global::OpenRouter.ChatContentItemsVariant3>? inputAudio = null,
            global::System.Action<global::OpenRouter.ChatContentItemsVariant4>? inputVideo = null,
            global::System.Action<global::OpenRouter.ChatContentItemsVariant5>? text = null,
            global::System.Action<global::OpenRouter.ChatContentItemsVariant6>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
            }
            else if (IsInputVideo)
            {
                inputVideo?.Invoke(InputVideo!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsVideoUrl)
            {
                videoUrl?.Invoke(VideoUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::OpenRouter.ChatContentItemsVariant1),
                ImageUrl,
                typeof(global::OpenRouter.ChatContentItemsVariant2),
                InputAudio,
                typeof(global::OpenRouter.ChatContentItemsVariant3),
                InputVideo,
                typeof(global::OpenRouter.ChatContentItemsVariant4),
                Text,
                typeof(global::OpenRouter.ChatContentItemsVariant5),
                VideoUrl,
                typeof(global::OpenRouter.ChatContentItemsVariant6),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentItemsVariant1?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentItemsVariant2?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentItemsVariant3?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentItemsVariant4?>.Default.Equals(InputVideo, other.InputVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentItemsVariant5?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentItemsVariant6?>.Default.Equals(VideoUrl, other.VideoUrl) 
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
