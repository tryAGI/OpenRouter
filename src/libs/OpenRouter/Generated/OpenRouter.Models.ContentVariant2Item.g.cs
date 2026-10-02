#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"text":"Hello, world!","type":"text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParam? Text { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParam? Text { get; }
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
            out global::OpenRouter.AnthropicTextBlockParam? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParam PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"source":{"data":"/9j/4AAQ...","media_type":"image/jpeg","type":"base64"},"type":"image"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicImageBlockParam? Image { get; init; }
#else
        public global::OpenRouter.AnthropicImageBlockParam? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicImageBlockParam? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParam PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::OpenRouter.AnthropicTextBlockParam value) => new ContentVariant2Item((global::OpenRouter.AnthropicTextBlockParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParam?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::OpenRouter.AnthropicTextBlockParam? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromText(global::OpenRouter.AnthropicTextBlockParam? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::OpenRouter.AnthropicImageBlockParam value) => new ContentVariant2Item((global::OpenRouter.AnthropicImageBlockParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicImageBlockParam?(ContentVariant2Item @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::OpenRouter.AnthropicImageBlockParam? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromImage(global::OpenRouter.AnthropicImageBlockParam? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(
            global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType? type,
            global::OpenRouter.AnthropicTextBlockParam? text,
            global::OpenRouter.AnthropicImageBlockParam? image
            )
        {
            Type = type;

            Text = text;
            Image = image;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Image as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage || !IsText && IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlockParam, TResult>? text = null,
            global::System.Func<global::OpenRouter.AnthropicImageBlockParam, TResult>? image = null,
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
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam>? text = null,

            global::System.Action<global::OpenRouter.AnthropicImageBlockParam>? image = null,
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
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam>? text = null,
            global::System.Action<global::OpenRouter.AnthropicImageBlockParam>? image = null,
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
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
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
                typeof(global::OpenRouter.AnthropicTextBlockParam),
                Image,
                typeof(global::OpenRouter.AnthropicImageBlockParam),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicImageBlockParam?>.Default.Equals(Image, other.Image)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
