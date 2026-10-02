#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation call with partial image<br/>
    /// Example: {"item_id":"call-123","output_index":0,"partial_image_b64":"base64encodedimage...","partial_image_index":0,"sequence_number":3,"type":"response.image_generation_call.partial_image"}
    /// </summary>
    public readonly partial struct ImageGenCallPartialImageEvent : global::System.IEquatable<ImageGenCallPartialImageEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ig_abc123","output_index":0,"partial_image_b64":"iVBORw0KGgo...","partial_image_index":0,"sequence_number":3,"type":"response.image_generation_call.partial_image"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? OpenAIResponses { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponses))]
#endif
        public bool IsOpenAIResponses => OpenAIResponses != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImage PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ImageGenCallPartialImageEventVariant2 { get; init; }
#else
        public object? ImageGenCallPartialImageEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallPartialImageEventVariant2))]
#endif
        public bool IsImageGenCallPartialImageEventVariant2 => ImageGenCallPartialImageEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenCallPartialImageEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ImageGenCallPartialImageEventVariant2;
            return IsImageGenCallPartialImageEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickImageGenCallPartialImageEventVariant2() => ImageGenCallPartialImageEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenCallPartialImageEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenCallPartialImageEvent(global::OpenRouter.OpenAIResponsesImageGenCallPartialImage value) => new ImageGenCallPartialImageEvent((global::OpenRouter.OpenAIResponsesImageGenCallPartialImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesImageGenCallPartialImage?(ImageGenCallPartialImageEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallPartialImageEvent(global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenCallPartialImageEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? value) => new ImageGenCallPartialImageEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallPartialImageEvent(
            global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? openAIResponses,
            object? imageGenCallPartialImageEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            ImageGenCallPartialImageEventVariant2 = imageGenCallPartialImageEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageGenCallPartialImageEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            ImageGenCallPartialImageEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsImageGenCallPartialImageEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesImageGenCallPartialImage, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? imageGenCallPartialImageEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0 && openAIResponses != null)
            {
                return openAIResponses(__value0);
            }
            else if (ImageGenCallPartialImageEventVariant2 is { } __value1 && imageGenCallPartialImageEventVariant2 != null)
            {
                return imageGenCallPartialImageEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallPartialImage>? openAIResponses = null,

            global::System.Action<object>? imageGenCallPartialImageEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0)
            {
                openAIResponses?.Invoke(__value0);
            }
            else if (ImageGenCallPartialImageEventVariant2 is { } __value1)
            {
                imageGenCallPartialImageEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallPartialImage>? openAIResponses = null,
            global::System.Action<object>? imageGenCallPartialImageEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0)
            {
                openAIResponses?.Invoke(__value0);
            }
            else if (ImageGenCallPartialImageEventVariant2 is { } __value1)
            {
                imageGenCallPartialImageEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIResponses,
                typeof(global::OpenRouter.OpenAIResponsesImageGenCallPartialImage),
                ImageGenCallPartialImageEventVariant2,
                typeof(object),
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
        public bool Equals(ImageGenCallPartialImageEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesImageGenCallPartialImage?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ImageGenCallPartialImageEventVariant2, other.ImageGenCallPartialImageEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ImageGenCallPartialImageEvent obj1, ImageGenCallPartialImageEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenCallPartialImageEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenCallPartialImageEvent obj1, ImageGenCallPartialImageEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenCallPartialImageEvent o && Equals(o);
        }
    }
}
