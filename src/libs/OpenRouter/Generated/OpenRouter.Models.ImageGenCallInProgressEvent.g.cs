#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation call in progress<br/>
    /// Example: {"item_id":"call-123","output_index":0,"sequence_number":1,"type":"response.image_generation_call.in_progress"}
    /// </summary>
    public readonly partial struct ImageGenCallInProgressEvent : global::System.IEquatable<ImageGenCallInProgressEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ig_abc123","output_index":0,"sequence_number":1,"type":"response.image_generation_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgress? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgress? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesImageGenCallInProgress? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgress PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ImageGenCallInProgressEventVariant2 { get; init; }
#else
        public object? ImageGenCallInProgressEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenCallInProgressEventVariant2))]
#endif
        public bool IsImageGenCallInProgressEventVariant2 => ImageGenCallInProgressEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenCallInProgressEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ImageGenCallInProgressEventVariant2;
            return IsImageGenCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickImageGenCallInProgressEventVariant2() => ImageGenCallInProgressEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenCallInProgressEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImageGenCallInProgressEvent(global::OpenRouter.OpenAIResponsesImageGenCallInProgress value) => new ImageGenCallInProgressEvent((global::OpenRouter.OpenAIResponsesImageGenCallInProgress?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesImageGenCallInProgress?(ImageGenCallInProgressEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallInProgressEvent(global::OpenRouter.OpenAIResponsesImageGenCallInProgress? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImageGenCallInProgressEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesImageGenCallInProgress? value) => new ImageGenCallInProgressEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ImageGenCallInProgressEvent(
            global::OpenRouter.OpenAIResponsesImageGenCallInProgress? openAIResponses,
            object? imageGenCallInProgressEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            ImageGenCallInProgressEventVariant2 = imageGenCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageGenCallInProgressEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            ImageGenCallInProgressEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsImageGenCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesImageGenCallInProgress, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? imageGenCallInProgressEventVariant2 = null,
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
            else if (ImageGenCallInProgressEventVariant2 is { } __value1 && imageGenCallInProgressEventVariant2 != null)
            {
                return imageGenCallInProgressEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallInProgress>? openAIResponses = null,

            global::System.Action<object>? imageGenCallInProgressEventVariant2 = null,
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
            else if (ImageGenCallInProgressEventVariant2 is { } __value1)
            {
                imageGenCallInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesImageGenCallInProgress>? openAIResponses = null,
            global::System.Action<object>? imageGenCallInProgressEventVariant2 = null,
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
            else if (ImageGenCallInProgressEventVariant2 is { } __value1)
            {
                imageGenCallInProgressEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesImageGenCallInProgress),
                ImageGenCallInProgressEventVariant2,
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
        public bool Equals(ImageGenCallInProgressEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesImageGenCallInProgress?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ImageGenCallInProgressEventVariant2, other.ImageGenCallInProgressEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ImageGenCallInProgressEvent obj1, ImageGenCallInProgressEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenCallInProgressEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenCallInProgressEvent obj1, ImageGenCallInProgressEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenCallInProgressEvent o && Equals(o);
        }
    }
}
