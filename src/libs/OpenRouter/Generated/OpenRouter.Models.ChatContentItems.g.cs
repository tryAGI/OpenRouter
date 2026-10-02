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
        public global::OpenRouter.LegacyChatContentVideo? InputVideo1 { get; init; }
#else
        public global::OpenRouter.LegacyChatContentVideo? InputVideo1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputVideo1))]
#endif
        public bool IsInputVideo1 => InputVideo1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputVideo1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.LegacyChatContentVideo? value)
        {
            value = InputVideo1;
            return IsInputVideo1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideo PickInputVideo1() => InputVideo1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputVideo1' but the value was {ToString()}.");

        /// <summary>
        /// Video input content part<br/>
        /// Example: {"type":"video_url","video_url":{"url":"https://example.com/video.mp4"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatContentVideo? InputVideo2 { get; init; }
#else
        public global::OpenRouter.ChatContentVideo? InputVideo2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputVideo2))]
#endif
        public bool IsInputVideo2 => InputVideo2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputVideo2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatContentVideo? value)
        {
            value = InputVideo2;
            return IsInputVideo2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideo PickInputVideo2() => InputVideo2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputVideo2' but the value was {ToString()}.");

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
        public static implicit operator global::OpenRouter.LegacyChatContentVideo?(ChatContentItems @this) => @this.InputVideo1;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.LegacyChatContentVideo? value)
        {
            InputVideo1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromInputVideo1(global::OpenRouter.LegacyChatContentVideo? value) => new ChatContentItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChatContentItems(global::OpenRouter.ChatContentVideo value) => new ChatContentItems((global::OpenRouter.ChatContentVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ChatContentVideo?(ChatContentItems @this) => @this.InputVideo2;

        /// <summary>
        ///
        /// </summary>
        public ChatContentItems(global::OpenRouter.ChatContentVideo? value)
        {
            InputVideo2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChatContentItems FromInputVideo2(global::OpenRouter.ChatContentVideo? value) => new ChatContentItems(value);

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
            global::OpenRouter.LegacyChatContentVideo? inputVideo1,
            global::OpenRouter.ChatContentVideo? inputVideo2,
            global::OpenRouter.ChatContentFile? file
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            InputAudio = inputAudio;
            InputVideo1 = inputVideo1;
            InputVideo2 = inputVideo2;
            File = file;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            File as object ??
            InputVideo2 as object ??
            InputVideo1 as object ??
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
            InputVideo1?.ToString() ??
            InputVideo2?.ToString() ??
            File?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsInputAudio && !IsInputVideo1 && !IsInputVideo2 && !IsFile || !IsText && IsImageUrl && !IsInputAudio && !IsInputVideo1 && !IsInputVideo2 && !IsFile || !IsText && !IsImageUrl && IsInputAudio && !IsInputVideo1 && !IsInputVideo2 && !IsFile || !IsText && !IsImageUrl && !IsInputAudio && IsInputVideo1 && !IsInputVideo2 && !IsFile || !IsText && !IsImageUrl && !IsInputAudio && !IsInputVideo1 && IsInputVideo2 && !IsFile || !IsText && !IsImageUrl && !IsInputAudio && !IsInputVideo1 && !IsInputVideo2 && IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatContentText, TResult>? text = null,
            global::System.Func<global::OpenRouter.ChatContentImage, TResult>? imageUrl = null,
            global::System.Func<global::OpenRouter.ChatContentAudio, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.LegacyChatContentVideo, TResult>? inputVideo1 = null,
            global::System.Func<global::OpenRouter.ChatContentVideo, TResult>? inputVideo2 = null,
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
            else if (InputVideo1 is { } __value3 && inputVideo1 != null)
            {
                return inputVideo1(__value3);
            }
            else if (InputVideo2 is { } __value4 && inputVideo2 != null)
            {
                return inputVideo2(__value4);
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

            global::System.Action<global::OpenRouter.LegacyChatContentVideo>? inputVideo1 = null,

            global::System.Action<global::OpenRouter.ChatContentVideo>? inputVideo2 = null,

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
            else if (InputVideo1 is { } __value3)
            {
                inputVideo1?.Invoke(__value3);
            }
            else if (InputVideo2 is { } __value4)
            {
                inputVideo2?.Invoke(__value4);
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
            global::System.Action<global::OpenRouter.LegacyChatContentVideo>? inputVideo1 = null,
            global::System.Action<global::OpenRouter.ChatContentVideo>? inputVideo2 = null,
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
            else if (InputVideo1 is { } __value3)
            {
                inputVideo1?.Invoke(__value3);
            }
            else if (InputVideo2 is { } __value4)
            {
                inputVideo2?.Invoke(__value4);
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
                InputVideo1,
                typeof(global::OpenRouter.LegacyChatContentVideo),
                InputVideo2,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LegacyChatContentVideo?>.Default.Equals(InputVideo1, other.InputVideo1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatContentVideo?>.Default.Equals(InputVideo2, other.InputVideo2) &&
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
