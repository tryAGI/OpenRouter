#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation call is generating<br/>
    /// Example: {"item_id":"call-123","output_index":0,"sequence_number":2,"type":"response.image_generation_call.generating"}
    /// </summary>
    public readonly partial struct ImageGenCallGeneratingEvent : global::System.IEquatable<ImageGenCallGeneratingEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ig_abc123","output_index":0,"sequence_number":2,"type":"response.image_generation_call.generating"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesImageGenCallGenerating? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesImageGenCallGenerating? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesImageGenCallGenerating? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGenerating PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ImageGenCallGeneratingEventVariant2 { get; init; }
#else
        public object? ImageGenCallGeneratingEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallGeneratingEventVariant2))]
#endif
        public bool IsImageGenCallGeneratingEventVariant2 => ImageGenCallGeneratingEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenCallGeneratingEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ImageGenCallGeneratingEventVariant2;
            return IsImageGenCallGeneratingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickImageGenCallGeneratingEventVariant2() => ImageGenCallGeneratingEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenCallGeneratingEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenCallGeneratingEvent(global::OpenRouter.OpenAIResponsesImageGenCallGenerating value) => new ImageGenCallGeneratingEvent((global::OpenRouter.OpenAIResponsesImageGenCallGenerating?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesImageGenCallGenerating?(ImageGenCallGeneratingEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallGeneratingEvent(global::OpenRouter.OpenAIResponsesImageGenCallGenerating? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenCallGeneratingEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesImageGenCallGenerating? value) => new ImageGenCallGeneratingEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallGeneratingEvent(
            global::OpenRouter.OpenAIResponsesImageGenCallGenerating? openAIResponses,
            object? imageGenCallGeneratingEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            ImageGenCallGeneratingEventVariant2 = imageGenCallGeneratingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageGenCallGeneratingEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            ImageGenCallGeneratingEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsImageGenCallGeneratingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesImageGenCallGenerating, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? imageGenCallGeneratingEventVariant2 = null,
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
            else if (ImageGenCallGeneratingEventVariant2 is { } __value1 && imageGenCallGeneratingEventVariant2 != null)
            {
                return imageGenCallGeneratingEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallGenerating>? openAIResponses = null,

            global::System.Action<object>? imageGenCallGeneratingEventVariant2 = null,
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
            else if (ImageGenCallGeneratingEventVariant2 is { } __value1)
            {
                imageGenCallGeneratingEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallGenerating>? openAIResponses = null,
            global::System.Action<object>? imageGenCallGeneratingEventVariant2 = null,
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
            else if (ImageGenCallGeneratingEventVariant2 is { } __value1)
            {
                imageGenCallGeneratingEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesImageGenCallGenerating),
                ImageGenCallGeneratingEventVariant2,
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
        public bool Equals(ImageGenCallGeneratingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesImageGenCallGenerating?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ImageGenCallGeneratingEventVariant2, other.ImageGenCallGeneratingEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ImageGenCallGeneratingEvent obj1, ImageGenCallGeneratingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenCallGeneratingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenCallGeneratingEvent obj1, ImageGenCallGeneratingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenCallGeneratingEvent o && Equals(o);
        }
    }
}
