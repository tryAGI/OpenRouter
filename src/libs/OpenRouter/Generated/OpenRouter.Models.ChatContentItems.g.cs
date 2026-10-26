#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Content part for chat completion messages<br/>
    /// Example: {"text":"Hello, world!","type":"text"}
    /// </summary>
    public readonly partial struct ChatContentItems : global::System.IEquatable<ChatContentItems>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// Text content part<br/>
        /// Example: {"text":"Hello, world!","type":"text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentText? Text { get; init; }
#else
        public global::OpenRouter.ChatContentText? Text { get; }
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
            out global::OpenRouter.ChatContentText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentText PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Image content part for vision models<br/>
        /// Example: {"image_url":{"detail":"auto","url":"https://example.com/image.jpg"},"type":"image_url"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentImage? ImageUrl { get; init; }
#else
        public global::OpenRouter.ChatContentImage? ImageUrl { get; }
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
            out global::OpenRouter.ChatContentImage? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImage PickImageUrl() => ImageUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        /// Audio input content part. Supported audio formats vary by provider.<br/>
        /// Example: {"input_audio":{"data":"SGVsbG8gV29ybGQ=","format":"wav"},"type":"input_audio"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentAudio? InputAudio { get; init; }
#else
        public global::OpenRouter.ChatContentAudio? InputAudio { get; }
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
            out global::OpenRouter.ChatContentAudio? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudio PickInputAudio() => InputAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudio' but the value was {ToString()}.");

        /// <summary>
        /// Video input content part (legacy format - deprecated)<br/>
        /// Example: {"type":"input_video","video_url":{"url":"https://example.com/video.mp4"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.LegacyChatContentVideo? InputVideo { get; init; }
#else
        public global::OpenRouter.LegacyChatContentVideo? InputVideo { get; }
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
            out global::OpenRouter.LegacyChatContentVideo? value)
        {
            value = InputVideo;
            return IsInputVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideo PickInputVideo() => InputVideo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputVideo' but the value was {ToString()}.");

        /// <summary>
        /// Video input content part<br/>
        /// Example: {"type":"video_url","video_url":{"url":"https://example.com/video.mp4"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentVideo? VideoUrl { get; init; }
#else
        public global::OpenRouter.ChatContentVideo? VideoUrl { get; }
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
            out global::OpenRouter.ChatContentVideo? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideo PickVideoUrl() => VideoUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUrl' but the value was {ToString()}.");

        /// <summary>
        /// File content part for document processing<br/>
        /// Example: {"file":{"file_data":"https://example.com/document.pdf","filename":"document.pdf"},"type":"file"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentFile? File { get; init; }
#else
        public global::OpenRouter.ChatContentFile? File { get; }
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
            out global::OpenRouter.ChatContentFile? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFile PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentText value) => new ChatContentItems((global::OpenRouter.ChatContentText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentText?(ChatContentItems @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromText(global::OpenRouter.ChatContentText? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentImage value) => new ChatContentItems((global::OpenRouter.ChatContentImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentImage?(ChatContentItems @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromImageUrl(global::OpenRouter.ChatContentImage? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentAudio value) => new ChatContentItems((global::OpenRouter.ChatContentAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentAudio?(ChatContentItems @this) => @this.InputAudio;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromInputAudio(global::OpenRouter.ChatContentAudio? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.LegacyChatContentVideo value) => new ChatContentItems((global::OpenRouter.LegacyChatContentVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.LegacyChatContentVideo?(ChatContentItems @this) => @this.InputVideo;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.LegacyChatContentVideo? value)
        {
            InputVideo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromInputVideo(global::OpenRouter.LegacyChatContentVideo? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentVideo value) => new ChatContentItems((global::OpenRouter.ChatContentVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentVideo?(ChatContentItems @this) => @this.VideoUrl;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentVideo? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromVideoUrl(global::OpenRouter.ChatContentVideo? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentFile value) => new ChatContentItems((global::OpenRouter.ChatContentFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentFile?(ChatContentItems @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentFile? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromFile(global::OpenRouter.ChatContentFile? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(
            global::OpenRouter.ChatContentItemsDiscriminatorType? type,
            global::OpenRouter.ChatContentText? text,
            global::OpenRouter.ChatContentImage? imageUrl,
            global::OpenRouter.ChatContentAudio? inputAudio,
            global::OpenRouter.LegacyChatContentVideo? inputVideo,
            global::OpenRouter.ChatContentVideo? videoUrl,
            global::OpenRouter.ChatContentFile? file
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            InputAudio = inputAudio;
            InputVideo = inputVideo;
            VideoUrl = videoUrl;
            File = file;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            File as object ??
            VideoUrl as object ??
            InputVideo as object ??
            InputAudio as object ??
            ImageUrl as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            InputAudio?.ToString() ??
            InputVideo?.ToString() ??
            VideoUrl?.ToString() ??
            File?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsInputAudio && !IsInputVideo && !IsVideoUrl && !IsFile || !IsText && IsImageUrl && !IsInputAudio && !IsInputVideo && !IsVideoUrl && !IsFile || !IsText && !IsImageUrl && IsInputAudio && !IsInputVideo && !IsVideoUrl && !IsFile || !IsText && !IsImageUrl && !IsInputAudio && IsInputVideo && !IsVideoUrl && !IsFile || !IsText && !IsImageUrl && !IsInputAudio && !IsInputVideo && IsVideoUrl && !IsFile || !IsText && !IsImageUrl && !IsInputAudio && !IsInputVideo && !IsVideoUrl && IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatContentText, TResult>? text = null,
            global::System.Func<global::OpenRouter.ChatContentImage, TResult>? imageUrl = null,
            global::System.Func<global::OpenRouter.ChatContentAudio, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.LegacyChatContentVideo, TResult>? inputVideo = null,
            global::System.Func<global::OpenRouter.ChatContentVideo, TResult>? videoUrl = null,
            global::System.Func<global::OpenRouter.ChatContentFile, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (ImageUrl is { } __value1 && imageUrl != null)
            {
                return imageUrl(__value1);
            }
            else if (InputAudio is { } __value2 && inputAudio != null)
            {
                return inputAudio(__value2);
            }
            else if (InputVideo is { } __value3 && inputVideo != null)
            {
                return inputVideo(__value3);
            }
            else if (VideoUrl is { } __value4 && videoUrl != null)
            {
                return videoUrl(__value4);
            }
            else if (File is { } __value5 && file != null)
            {
                return file(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatContentText>? text = null,

            global::System.Action<global::OpenRouter.ChatContentImage>? imageUrl = null,

            global::System.Action<global::OpenRouter.ChatContentAudio>? inputAudio = null,

            global::System.Action<global::OpenRouter.LegacyChatContentVideo>? inputVideo = null,

            global::System.Action<global::OpenRouter.ChatContentVideo>? videoUrl = null,

            global::System.Action<global::OpenRouter.ChatContentFile>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ImageUrl is { } __value1)
            {
                imageUrl?.Invoke(__value1);
            }
            else if (InputAudio is { } __value2)
            {
                inputAudio?.Invoke(__value2);
            }
            else if (InputVideo is { } __value3)
            {
                inputVideo?.Invoke(__value3);
            }
            else if (VideoUrl is { } __value4)
            {
                videoUrl?.Invoke(__value4);
            }
            else if (File is { } __value5)
            {
                file?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatContentText>? text = null,
            global::System.Action<global::OpenRouter.ChatContentImage>? imageUrl = null,
            global::System.Action<global::OpenRouter.ChatContentAudio>? inputAudio = null,
            global::System.Action<global::OpenRouter.LegacyChatContentVideo>? inputVideo = null,
            global::System.Action<global::OpenRouter.ChatContentVideo>? videoUrl = null,
            global::System.Action<global::OpenRouter.ChatContentFile>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ImageUrl is { } __value1)
            {
                imageUrl?.Invoke(__value1);
            }
            else if (InputAudio is { } __value2)
            {
                inputAudio?.Invoke(__value2);
            }
            else if (InputVideo is { } __value3)
            {
                inputVideo?.Invoke(__value3);
            }
            else if (VideoUrl is { } __value4)
            {
                videoUrl?.Invoke(__value4);
            }
            else if (File is { } __value5)
            {
                file?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::OpenRouter.ChatContentText),
                ImageUrl,
                typeof(global::OpenRouter.ChatContentImage),
                InputAudio,
                typeof(global::OpenRouter.ChatContentAudio),
                InputVideo,
                typeof(global::OpenRouter.LegacyChatContentVideo),
                VideoUrl,
                typeof(global::OpenRouter.ChatContentVideo),
                File,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentImage?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LegacyChatContentVideo?>.Default.Equals(InputVideo, other.InputVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentVideo?>.Default.Equals(VideoUrl, other.VideoUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentFile?>.Default.Equals(File, other.File)
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
