#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicDocumentBlockParamSourceOneOf2Content : global::System.IEquatable<AnthropicDocumentBlockParamSourceOneOf2Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnthropicDocumentBlockParamSourceOneOf2ContentVariant1 { get; init; }
#else
        public string? AnthropicDocumentBlockParamSourceOneOf2ContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicDocumentBlockParamSourceOneOf2ContentVariant1))]
#endif
        public bool IsAnthropicDocumentBlockParamSourceOneOf2ContentVariant1 => AnthropicDocumentBlockParamSourceOneOf2ContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>? AnthropicDocumentBlockParamSourceOneOf2Content1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>? AnthropicDocumentBlockParamSourceOneOf2Content1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicDocumentBlockParamSourceOneOf2Content1))]
#endif
        public bool IsAnthropicDocumentBlockParamSourceOneOf2Content1 => AnthropicDocumentBlockParamSourceOneOf2Content1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicDocumentBlockParamSourceOneOf2Content(string value) => new AnthropicDocumentBlockParamSourceOneOf2Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnthropicDocumentBlockParamSourceOneOf2Content @this) => @this.AnthropicDocumentBlockParamSourceOneOf2ContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2Content(string? value)
        {
            AnthropicDocumentBlockParamSourceOneOf2ContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2Content(
            string? anthropicDocumentBlockParamSourceOneOf2ContentVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>? anthropicDocumentBlockParamSourceOneOf2Content1
            )
        {
            AnthropicDocumentBlockParamSourceOneOf2ContentVariant1 = anthropicDocumentBlockParamSourceOneOf2ContentVariant1;
            AnthropicDocumentBlockParamSourceOneOf2Content1 = anthropicDocumentBlockParamSourceOneOf2Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicDocumentBlockParamSourceOneOf2Content1 as object ??
            AnthropicDocumentBlockParamSourceOneOf2ContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicDocumentBlockParamSourceOneOf2ContentVariant1?.ToString() ??
            AnthropicDocumentBlockParamSourceOneOf2Content1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicDocumentBlockParamSourceOneOf2ContentVariant1 && !IsAnthropicDocumentBlockParamSourceOneOf2Content1 || !IsAnthropicDocumentBlockParamSourceOneOf2ContentVariant1 && IsAnthropicDocumentBlockParamSourceOneOf2Content1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? anthropicDocumentBlockParamSourceOneOf2ContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>?, TResult>? anthropicDocumentBlockParamSourceOneOf2Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicDocumentBlockParamSourceOneOf2ContentVariant1 && anthropicDocumentBlockParamSourceOneOf2ContentVariant1 != null)
            {
                return anthropicDocumentBlockParamSourceOneOf2ContentVariant1(AnthropicDocumentBlockParamSourceOneOf2ContentVariant1!);
            }
            else if (IsAnthropicDocumentBlockParamSourceOneOf2Content1 && anthropicDocumentBlockParamSourceOneOf2Content1 != null)
            {
                return anthropicDocumentBlockParamSourceOneOf2Content1(AnthropicDocumentBlockParamSourceOneOf2Content1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? anthropicDocumentBlockParamSourceOneOf2ContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>?>? anthropicDocumentBlockParamSourceOneOf2Content1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicDocumentBlockParamSourceOneOf2ContentVariant1)
            {
                anthropicDocumentBlockParamSourceOneOf2ContentVariant1?.Invoke(AnthropicDocumentBlockParamSourceOneOf2ContentVariant1!);
            }
            else if (IsAnthropicDocumentBlockParamSourceOneOf2Content1)
            {
                anthropicDocumentBlockParamSourceOneOf2Content1?.Invoke(AnthropicDocumentBlockParamSourceOneOf2Content1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicDocumentBlockParamSourceOneOf2ContentVariant1,
                typeof(string),
                AnthropicDocumentBlockParamSourceOneOf2Content1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>),
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
        public bool Equals(AnthropicDocumentBlockParamSourceOneOf2Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnthropicDocumentBlockParamSourceOneOf2ContentVariant1, other.AnthropicDocumentBlockParamSourceOneOf2ContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>?>.Default.Equals(AnthropicDocumentBlockParamSourceOneOf2Content1, other.AnthropicDocumentBlockParamSourceOneOf2Content1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicDocumentBlockParamSourceOneOf2Content obj1, AnthropicDocumentBlockParamSourceOneOf2Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicDocumentBlockParamSourceOneOf2Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicDocumentBlockParamSourceOneOf2Content obj1, AnthropicDocumentBlockParamSourceOneOf2Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicDocumentBlockParamSourceOneOf2Content o && Equals(o);
        }
    }
}
