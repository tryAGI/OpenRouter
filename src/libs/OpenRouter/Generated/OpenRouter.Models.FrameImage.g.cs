#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"frame_type":"first_frame","image_url":{"url":"https://example.com/image.png"},"type":"image_url"}
    /// </summary>
    public readonly partial struct FrameImage : global::System.IEquatable<FrameImage>
    {
        /// <summary>
        /// Example: {"image_url":{"url":"https://example.com/image.png"},"type":"image_url"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartImage? ContentPart { get; init; }
#else
        public global::OpenRouter.ContentPartImage? ContentPart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPart))]
#endif
        public bool IsContentPart => ContentPart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentPart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartImage? value)
        {
            value = ContentPart;
            return IsContentPart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImage PickContentPart() => ContentPart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentPart' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FrameImageVariant2? FrameImageVariant2 { get; init; }
#else
        public global::OpenRouter.FrameImageVariant2? FrameImageVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FrameImageVariant2))]
#endif
        public bool IsFrameImageVariant2 => FrameImageVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFrameImageVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FrameImageVariant2? value)
        {
            value = FrameImageVariant2;
            return IsFrameImageVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2 PickFrameImageVariant2() => FrameImageVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FrameImageVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FrameImage(global::OpenRouter.ContentPartImage value) => new FrameImage((global::OpenRouter.ContentPartImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartImage?(FrameImage @this) => @this.ContentPart;

        /// <summary>
        ///
        /// </summary>
        public FrameImage(global::OpenRouter.ContentPartImage? value)
        {
            ContentPart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FrameImage FromContentPart(global::OpenRouter.ContentPartImage? value) => new FrameImage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FrameImage(global::OpenRouter.FrameImageVariant2 value) => new FrameImage((global::OpenRouter.FrameImageVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FrameImageVariant2?(FrameImage @this) => @this.FrameImageVariant2;

        /// <summary>
        ///
        /// </summary>
        public FrameImage(global::OpenRouter.FrameImageVariant2? value)
        {
            FrameImageVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FrameImage FromFrameImageVariant2(global::OpenRouter.FrameImageVariant2? value) => new FrameImage(value);

        /// <summary>
        ///
        /// </summary>
        public FrameImage(
            global::OpenRouter.ContentPartImage? contentPart,
            global::OpenRouter.FrameImageVariant2? frameImageVariant2
            )
        {
            ContentPart = contentPart;
            FrameImageVariant2 = frameImageVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FrameImageVariant2 as object ??
            ContentPart as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ContentPart?.ToString() ??
            FrameImageVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsContentPart && IsFrameImageVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ContentPartImage, TResult>? contentPart = null,
            global::System.Func<global::OpenRouter.FrameImageVariant2, TResult>? frameImageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContentPart is { } __value0 && contentPart != null)
            {
                return contentPart(__value0);
            }
            else if (FrameImageVariant2 is { } __value1 && frameImageVariant2 != null)
            {
                return frameImageVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ContentPartImage>? contentPart = null,

            global::System.Action<global::OpenRouter.FrameImageVariant2>? frameImageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContentPart is { } __value0)
            {
                contentPart?.Invoke(__value0);
            }
            else if (FrameImageVariant2 is { } __value1)
            {
                frameImageVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ContentPartImage>? contentPart = null,
            global::System.Action<global::OpenRouter.FrameImageVariant2>? frameImageVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContentPart is { } __value0)
            {
                contentPart?.Invoke(__value0);
            }
            else if (FrameImageVariant2 is { } __value1)
            {
                frameImageVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContentPart,
                typeof(global::OpenRouter.ContentPartImage),
                FrameImageVariant2,
                typeof(global::OpenRouter.FrameImageVariant2),
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
        public bool Equals(FrameImage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartImage?>.Default.Equals(ContentPart, other.ContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FrameImageVariant2?>.Default.Equals(FrameImageVariant2, other.FrameImageVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FrameImage obj1, FrameImage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FrameImage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FrameImage obj1, FrameImage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FrameImage o && Equals(o);
        }
    }
}
