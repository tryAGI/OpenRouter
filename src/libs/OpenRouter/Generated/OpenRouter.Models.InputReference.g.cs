#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A reference asset used to guide video generation. Image references are supported by all providers; audio and video references are only honored by providers that support them (currently BytePlus Seedance 2.0).
    /// </summary>
    public readonly partial struct InputReference : global::System.IEquatable<InputReference>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorType? Type { get; }

        /// <summary>
        /// audio_url variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputReferenceVariant1? AudioUrl { get; init; }
#else
        public global::OpenRouter.InputReferenceVariant1? AudioUrl { get; }
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
            out global::OpenRouter.InputReferenceVariant1? value)
        {
            value = AudioUrl;
            return IsAudioUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputReferenceVariant1 PickAudioUrl() => IsAudioUrl
            ? AudioUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioUrl' but the value was {ToString()}.");

        /// <summary>
        /// image_url variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputReferenceVariant2? ImageUrl { get; init; }
#else
        public global::OpenRouter.InputReferenceVariant2? ImageUrl { get; }
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
            out global::OpenRouter.InputReferenceVariant2? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputReferenceVariant2 PickImageUrl() => IsImageUrl
            ? ImageUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        /// video_url variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputReferenceVariant3? VideoUrl { get; init; }
#else
        public global::OpenRouter.InputReferenceVariant3? VideoUrl { get; }
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
            out global::OpenRouter.InputReferenceVariant3? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputReferenceVariant3 PickVideoUrl() => IsVideoUrl
            ? VideoUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUrl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputReference(global::OpenRouter.InputReferenceVariant1 value) => new InputReference((global::OpenRouter.InputReferenceVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputReferenceVariant1?(InputReference @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public InputReference(global::OpenRouter.InputReferenceVariant1? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputReference FromAudioUrl(global::OpenRouter.InputReferenceVariant1? value) => new InputReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputReference(global::OpenRouter.InputReferenceVariant2 value) => new InputReference((global::OpenRouter.InputReferenceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputReferenceVariant2?(InputReference @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public InputReference(global::OpenRouter.InputReferenceVariant2? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputReference FromImageUrl(global::OpenRouter.InputReferenceVariant2? value) => new InputReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputReference(global::OpenRouter.InputReferenceVariant3 value) => new InputReference((global::OpenRouter.InputReferenceVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputReferenceVariant3?(InputReference @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public InputReference(global::OpenRouter.InputReferenceVariant3? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputReference FromVideoUrl(global::OpenRouter.InputReferenceVariant3? value) => new InputReference(value);

        /// <summary>
        /// 
        /// </summary>
        public InputReference(
            global::OpenRouter.InputReferenceDiscriminatorType? type,
            global::OpenRouter.InputReferenceVariant1? audioUrl,
            global::OpenRouter.InputReferenceVariant2? imageUrl,
            global::OpenRouter.InputReferenceVariant3? videoUrl
            )
        {
            Type = type;

            AudioUrl = audioUrl;
            ImageUrl = imageUrl;
            VideoUrl = videoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            ImageUrl as object ??
            AudioUrl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioUrl?.ToString() ??
            ImageUrl?.ToString() ??
            VideoUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioUrl && !IsImageUrl && !IsVideoUrl || !IsAudioUrl && IsImageUrl && !IsVideoUrl || !IsAudioUrl && !IsImageUrl && IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InputReferenceVariant1, TResult>? audioUrl = null,
            global::System.Func<global::OpenRouter.InputReferenceVariant2, TResult>? imageUrl = null,
            global::System.Func<global::OpenRouter.InputReferenceVariant3, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioUrl && audioUrl != null)
            {
                return audioUrl(AudioUrl!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
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
            global::System.Action<global::OpenRouter.InputReferenceVariant1>? audioUrl = null,

            global::System.Action<global::OpenRouter.InputReferenceVariant2>? imageUrl = null,

            global::System.Action<global::OpenRouter.InputReferenceVariant3>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
            global::System.Action<global::OpenRouter.InputReferenceVariant1>? audioUrl = null,
            global::System.Action<global::OpenRouter.InputReferenceVariant2>? imageUrl = null,
            global::System.Action<global::OpenRouter.InputReferenceVariant3>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
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
                AudioUrl,
                typeof(global::OpenRouter.InputReferenceVariant1),
                ImageUrl,
                typeof(global::OpenRouter.InputReferenceVariant2),
                VideoUrl,
                typeof(global::OpenRouter.InputReferenceVariant3),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputReferenceVariant1?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputReferenceVariant2?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputReferenceVariant3?>.Default.Equals(VideoUrl, other.VideoUrl) 
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
