#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation call completed<br/>
    /// Example: {"item_id":"call-123","output_index":0,"sequence_number":4,"type":"response.image_generation_call.completed"}
    /// </summary>
    public readonly partial struct ImageGenCallCompletedEvent : global::System.IEquatable<ImageGenCallCompletedEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ig_abc123","output_index":0,"sequence_number":4,"type":"response.image_generation_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesImageGenCallCompleted? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesImageGenCallCompleted? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesImageGenCallCompleted? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompleted PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ImageGenCallCompletedEventVariant2 { get; init; }
#else
        public object? ImageGenCallCompletedEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallCompletedEventVariant2))]
#endif
        public bool IsImageGenCallCompletedEventVariant2 => ImageGenCallCompletedEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenCallCompletedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ImageGenCallCompletedEventVariant2;
            return IsImageGenCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickImageGenCallCompletedEventVariant2() => ImageGenCallCompletedEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenCallCompletedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenCallCompletedEvent(global::OpenRouter.OpenAIResponsesImageGenCallCompleted value) => new ImageGenCallCompletedEvent((global::OpenRouter.OpenAIResponsesImageGenCallCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesImageGenCallCompleted?(ImageGenCallCompletedEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallCompletedEvent(global::OpenRouter.OpenAIResponsesImageGenCallCompleted? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenCallCompletedEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesImageGenCallCompleted? value) => new ImageGenCallCompletedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallCompletedEvent(
            global::OpenRouter.OpenAIResponsesImageGenCallCompleted? openAIResponses,
            object? imageGenCallCompletedEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            ImageGenCallCompletedEventVariant2 = imageGenCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageGenCallCompletedEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            ImageGenCallCompletedEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsImageGenCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesImageGenCallCompleted, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? imageGenCallCompletedEventVariant2 = null,
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
            else if (ImageGenCallCompletedEventVariant2 is { } __value1 && imageGenCallCompletedEventVariant2 != null)
            {
                return imageGenCallCompletedEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallCompleted>? openAIResponses = null,

            global::System.Action<object>? imageGenCallCompletedEventVariant2 = null,
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
            else if (ImageGenCallCompletedEventVariant2 is { } __value1)
            {
                imageGenCallCompletedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallCompleted>? openAIResponses = null,
            global::System.Action<object>? imageGenCallCompletedEventVariant2 = null,
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
            else if (ImageGenCallCompletedEventVariant2 is { } __value1)
            {
                imageGenCallCompletedEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesImageGenCallCompleted),
                ImageGenCallCompletedEventVariant2,
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
        public bool Equals(ImageGenCallCompletedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesImageGenCallCompleted?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ImageGenCallCompletedEventVariant2, other.ImageGenCallCompletedEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ImageGenCallCompletedEvent obj1, ImageGenCallCompletedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenCallCompletedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenCallCompletedEvent obj1, ImageGenCallCompletedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenCallCompletedEvent o && Equals(o);
        }
    }
}
