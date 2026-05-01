#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items : global::System.IEquatable<AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>
    {
        /// <summary>
        /// image variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1? Image { get; init; }
#else
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// text variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2? Text { get; init; }
#else
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2? Text { get; }
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
        public static implicit operator AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1 value) => new AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items((global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1?(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2 value) => new AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items((global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2?(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1? image,
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2? text
            )
        {
            Image = image;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Image as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImage && !IsText || !IsImage && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1?, TResult>? image = null,
            global::System.Func<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1?>? image = null,
            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Image,
                typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1),
                Text,
                typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2),
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
        public bool Equals(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items obj1, AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items obj1, AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items o && Equals(o);
        }
    }
}
