#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A reference asset used to guide video generation. Image references are supported by all providers; audio and video references are only honored by providers that support them (including BytePlus Seedance generation 2 and newer).<br/>
    /// Example: {"image_url":{"url":"https://example.com/image.png"},"type":"image_url"}
    /// </summary>
    public readonly partial struct InputReference : global::System.IEquatable<InputReference>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"image_url":{"url":"https://example.com/image.png"},"type":"image_url"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartImage? ImageUrl { get; init; }
#else
        public global::OpenRouter.ContentPartImage? ImageUrl { get; }
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
            out global::OpenRouter.ContentPartImage? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImage PickImageUrl() => ImageUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"audio_url":{"url":"https://example.com/audio.mp3"},"type":"audio_url"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartAudio? AudioUrl { get; init; }
#else
        public global::OpenRouter.ContentPartAudio? AudioUrl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl))]
#endif
        public bool IsAudioUrl => AudioUrl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartAudio? value)
        {
            value = AudioUrl;
            return IsAudioUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudio PickAudioUrl() => AudioUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioUrl' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"type":"video_url","video_url":{"url":"https://example.com/clip.mp4"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartVideo? VideoUrl { get; init; }
#else
        public global::OpenRouter.ContentPartVideo? VideoUrl { get; }
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
            out global::OpenRouter.ContentPartVideo? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideo PickVideoUrl() => VideoUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUrl' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputReference(global::OpenRouter.ContentPartImage value) => new InputReference((global::OpenRouter.ContentPartImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartImage?(InputReference @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public InputReference(global::OpenRouter.ContentPartImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputReference FromImageUrl(global::OpenRouter.ContentPartImage? value) => new InputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputReference(global::OpenRouter.ContentPartAudio value) => new InputReference((global::OpenRouter.ContentPartAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartAudio?(InputReference @this) => @this.AudioUrl;

        /// <summary>
        ///
        /// </summary>
        public InputReference(global::OpenRouter.ContentPartAudio? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputReference FromAudioUrl(global::OpenRouter.ContentPartAudio? value) => new InputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputReference(global::OpenRouter.ContentPartVideo value) => new InputReference((global::OpenRouter.ContentPartVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartVideo?(InputReference @this) => @this.VideoUrl;

        /// <summary>
        ///
        /// </summary>
        public InputReference(global::OpenRouter.ContentPartVideo? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputReference FromVideoUrl(global::OpenRouter.ContentPartVideo? value) => new InputReference(value);

        /// <summary>
        ///
        /// </summary>
        public InputReference(
            global::OpenRouter.InputReferenceDiscriminatorType? type,
            global::OpenRouter.ContentPartImage? imageUrl,
            global::OpenRouter.ContentPartAudio? audioUrl,
            global::OpenRouter.ContentPartVideo? videoUrl
            )
        {
            Type = type;

            ImageUrl = imageUrl;
            AudioUrl = audioUrl;
            VideoUrl = videoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            AudioUrl as object ??
            ImageUrl as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ImageUrl?.ToString() ??
            AudioUrl?.ToString() ??
            VideoUrl?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsImageUrl && IsAudioUrl && !IsVideoUrl || !IsImageUrl && !IsAudioUrl && IsVideoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ContentPartImage, TResult>? imageUrl = null,
            global::System.Func<global::OpenRouter.ContentPartAudio, TResult>? audioUrl = null,
            global::System.Func<global::OpenRouter.ContentPartVideo, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageUrl is { } __value0 && imageUrl != null)
            {
                return imageUrl(__value0);
            }
            else if (AudioUrl is { } __value1 && audioUrl != null)
            {
                return audioUrl(__value1);
            }
            else if (VideoUrl is { } __value2 && videoUrl != null)
            {
                return videoUrl(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ContentPartImage>? imageUrl = null,

            global::System.Action<global::OpenRouter.ContentPartAudio>? audioUrl = null,

            global::System.Action<global::OpenRouter.ContentPartVideo>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageUrl is { } __value0)
            {
                imageUrl?.Invoke(__value0);
            }
            else if (AudioUrl is { } __value1)
            {
                audioUrl?.Invoke(__value1);
            }
            else if (VideoUrl is { } __value2)
            {
                videoUrl?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ContentPartImage>? imageUrl = null,
            global::System.Action<global::OpenRouter.ContentPartAudio>? audioUrl = null,
            global::System.Action<global::OpenRouter.ContentPartVideo>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageUrl is { } __value0)
            {
                imageUrl?.Invoke(__value0);
            }
            else if (AudioUrl is { } __value1)
            {
                audioUrl?.Invoke(__value1);
            }
            else if (VideoUrl is { } __value2)
            {
                videoUrl?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageUrl,
                typeof(global::OpenRouter.ContentPartImage),
                AudioUrl,
                typeof(global::OpenRouter.ContentPartAudio),
                VideoUrl,
                typeof(global::OpenRouter.ContentPartVideo),
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
        public bool Equals(InputReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartImage?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartAudio?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartVideo?>.Default.Equals(VideoUrl, other.VideoUrl)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputReference obj1, InputReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputReference obj1, InputReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputReference o && Equals(o);
        }
    }
}
