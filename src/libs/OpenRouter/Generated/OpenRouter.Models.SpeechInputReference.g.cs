#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference content part for stateless voice cloning or voice design
    /// </summary>
    public readonly partial struct SpeechInputReference : global::System.IEquatable<SpeechInputReference>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminatorType? Type { get; }

        /// <summary>
        /// Reference audio input for stateless voice cloning. Up to three parts per request; the Nth audio part is addressable from `input` as `@AudioN` on providers that support multiple references.<br/>
        /// Example: {"input_audio":{"data":"data:audio/wav;base64,UklGRuQXDABXQVZF..."},"type":"input_audio"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SpeechInputReferenceAudio? InputAudio { get; init; }
#else
        public global::OpenRouter.SpeechInputReferenceAudio? InputAudio { get; }
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
            out global::OpenRouter.SpeechInputReferenceAudio? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudio PickInputAudio() => InputAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudio' but the value was {ToString()}.");

        /// <summary>
        /// Transcript of an `input_audio` part<br/>
        /// Example: {"text":"I used to rule the world.","type":"text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SpeechInputReferenceText? Text { get; init; }
#else
        public global::OpenRouter.SpeechInputReferenceText? Text { get; }
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
            out global::OpenRouter.SpeechInputReferenceText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceText PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Reference image describing the desired voice. Cannot be combined with `input_audio` parts. Only routed to endpoints that support image references.<br/>
        /// Example: {"image_url":{"url":"data:image/png;base64,iVBORw0KGgo..."},"type":"image_url"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SpeechInputReferenceImage? ImageUrl { get; init; }
#else
        public global::OpenRouter.SpeechInputReferenceImage? ImageUrl { get; }
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
            out global::OpenRouter.SpeechInputReferenceImage? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImage PickImageUrl() => ImageUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInputReference(global::OpenRouter.SpeechInputReferenceAudio value) => new SpeechInputReference((global::OpenRouter.SpeechInputReferenceAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SpeechInputReferenceAudio?(SpeechInputReference @this) => @this.InputAudio;

        /// <summary>
        ///
        /// </summary>
        public SpeechInputReference(global::OpenRouter.SpeechInputReferenceAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInputReference FromInputAudio(global::OpenRouter.SpeechInputReferenceAudio? value) => new SpeechInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInputReference(global::OpenRouter.SpeechInputReferenceText value) => new SpeechInputReference((global::OpenRouter.SpeechInputReferenceText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SpeechInputReferenceText?(SpeechInputReference @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public SpeechInputReference(global::OpenRouter.SpeechInputReferenceText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInputReference FromText(global::OpenRouter.SpeechInputReferenceText? value) => new SpeechInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInputReference(global::OpenRouter.SpeechInputReferenceImage value) => new SpeechInputReference((global::OpenRouter.SpeechInputReferenceImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SpeechInputReferenceImage?(SpeechInputReference @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public SpeechInputReference(global::OpenRouter.SpeechInputReferenceImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInputReference FromImageUrl(global::OpenRouter.SpeechInputReferenceImage? value) => new SpeechInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public SpeechInputReference(
            global::OpenRouter.SpeechInputReferenceDiscriminatorType? type,
            global::OpenRouter.SpeechInputReferenceAudio? inputAudio,
            global::OpenRouter.SpeechInputReferenceText? text,
            global::OpenRouter.SpeechInputReferenceImage? imageUrl
            )
        {
            Type = type;

            InputAudio = inputAudio;
            Text = text;
            ImageUrl = imageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageUrl as object ??
            Text as object ??
            InputAudio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputAudio?.ToString() ??
            Text?.ToString() ??
            ImageUrl?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputAudio && !IsText && !IsImageUrl || !IsInputAudio && IsText && !IsImageUrl || !IsInputAudio && !IsText && IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.SpeechInputReferenceAudio, TResult>? inputAudio = null,
            global::System.Func<global::OpenRouter.SpeechInputReferenceText, TResult>? text = null,
            global::System.Func<global::OpenRouter.SpeechInputReferenceImage, TResult>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputAudio is { } __value0 && inputAudio != null)
            {
                return inputAudio(__value0);
            }
            else if (Text is { } __value1 && text != null)
            {
                return text(__value1);
            }
            else if (ImageUrl is { } __value2 && imageUrl != null)
            {
                return imageUrl(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.SpeechInputReferenceAudio>? inputAudio = null,

            global::System.Action<global::OpenRouter.SpeechInputReferenceText>? text = null,

            global::System.Action<global::OpenRouter.SpeechInputReferenceImage>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputAudio is { } __value0)
            {
                inputAudio?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
            else if (ImageUrl is { } __value2)
            {
                imageUrl?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.SpeechInputReferenceAudio>? inputAudio = null,
            global::System.Action<global::OpenRouter.SpeechInputReferenceText>? text = null,
            global::System.Action<global::OpenRouter.SpeechInputReferenceImage>? imageUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputAudio is { } __value0)
            {
                inputAudio?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
            else if (ImageUrl is { } __value2)
            {
                imageUrl?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputAudio,
                typeof(global::OpenRouter.SpeechInputReferenceAudio),
                Text,
                typeof(global::OpenRouter.SpeechInputReferenceText),
                ImageUrl,
                typeof(global::OpenRouter.SpeechInputReferenceImage),
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
        public bool Equals(SpeechInputReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SpeechInputReferenceAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SpeechInputReferenceText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SpeechInputReferenceImage?>.Default.Equals(ImageUrl, other.ImageUrl)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpeechInputReference obj1, SpeechInputReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechInputReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechInputReference obj1, SpeechInputReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechInputReference o && Equals(o);
        }
    }
}
