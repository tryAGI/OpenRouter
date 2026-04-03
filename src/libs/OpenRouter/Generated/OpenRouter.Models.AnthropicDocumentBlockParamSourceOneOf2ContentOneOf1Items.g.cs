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
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParam? AnthropicTextBlockParam { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParam? AnthropicTextBlockParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextBlockParam))]
#endif
        public bool IsAnthropicTextBlockParam => AnthropicTextBlockParam != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicImageBlockParam? AnthropicImageBlockParam { get; init; }
#else
        public global::OpenRouter.AnthropicImageBlockParam? AnthropicImageBlockParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicImageBlockParam))]
#endif
        public bool IsAnthropicImageBlockParam => AnthropicImageBlockParam != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicTextBlockParam value) => new AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items((global::OpenRouter.AnthropicTextBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParam?(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items @this) => @this.AnthropicTextBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicTextBlockParam? value)
        {
            AnthropicTextBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicImageBlockParam value) => new AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items((global::OpenRouter.AnthropicImageBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicImageBlockParam?(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items @this) => @this.AnthropicImageBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(global::OpenRouter.AnthropicImageBlockParam? value)
        {
            AnthropicImageBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(
            global::OpenRouter.AnthropicTextBlockParam? anthropicTextBlockParam,
            global::OpenRouter.AnthropicImageBlockParam? anthropicImageBlockParam
            )
        {
            AnthropicTextBlockParam = anthropicTextBlockParam;
            AnthropicImageBlockParam = anthropicImageBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicImageBlockParam as object ??
            AnthropicTextBlockParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicTextBlockParam?.ToString() ??
            AnthropicImageBlockParam?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam || !IsAnthropicTextBlockParam && IsAnthropicImageBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlockParam?, TResult>? anthropicTextBlockParam = null,
            global::System.Func<global::OpenRouter.AnthropicImageBlockParam?, TResult>? anthropicImageBlockParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlockParam && anthropicTextBlockParam != null)
            {
                return anthropicTextBlockParam(AnthropicTextBlockParam!);
            }
            else if (IsAnthropicImageBlockParam && anthropicImageBlockParam != null)
            {
                return anthropicImageBlockParam(AnthropicImageBlockParam!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam?>? anthropicTextBlockParam = null,
            global::System.Action<global::OpenRouter.AnthropicImageBlockParam?>? anthropicImageBlockParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlockParam)
            {
                anthropicTextBlockParam?.Invoke(AnthropicTextBlockParam!);
            }
            else if (IsAnthropicImageBlockParam)
            {
                anthropicImageBlockParam?.Invoke(AnthropicImageBlockParam!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicTextBlockParam,
                typeof(global::OpenRouter.AnthropicTextBlockParam),
                AnthropicImageBlockParam,
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
        public bool Equals(AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParam?>.Default.Equals(AnthropicTextBlockParam, other.AnthropicTextBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicImageBlockParam?>.Default.Equals(AnthropicImageBlockParam, other.AnthropicImageBlockParam) 
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
