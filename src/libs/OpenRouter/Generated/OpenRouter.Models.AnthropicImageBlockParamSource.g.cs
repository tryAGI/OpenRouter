#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicImageBlockParamSource : global::System.IEquatable<AnthropicImageBlockParamSource>
    {
        /// <summary>
        /// base64 variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant1? Base64 { get; init; }
#else
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant1? Base64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        /// url variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant2? Url { get; init; }
#else
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant2? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicImageBlockParamSource(global::OpenRouter.AnthropicImageBlockParamSourceVariant1 value) => new AnthropicImageBlockParamSource((global::OpenRouter.AnthropicImageBlockParamSourceVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicImageBlockParamSourceVariant1?(AnthropicImageBlockParamSource @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(global::OpenRouter.AnthropicImageBlockParamSourceVariant1? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicImageBlockParamSource(global::OpenRouter.AnthropicImageBlockParamSourceVariant2 value) => new AnthropicImageBlockParamSource((global::OpenRouter.AnthropicImageBlockParamSourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicImageBlockParamSourceVariant2?(AnthropicImageBlockParamSource @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(global::OpenRouter.AnthropicImageBlockParamSourceVariant2? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(
            global::OpenRouter.AnthropicImageBlockParamSourceVariant1? base64,
            global::OpenRouter.AnthropicImageBlockParamSourceVariant2? url
            )
        {
            Base64 = base64;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsUrl || !IsBase64 && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicImageBlockParamSourceVariant1?, TResult>? base64 = null,
            global::System.Func<global::OpenRouter.AnthropicImageBlockParamSourceVariant2?, TResult>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64 && base64 != null)
            {
                return base64(Base64!);
            }
            else if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicImageBlockParamSourceVariant1?>? base64 = null,
            global::System.Action<global::OpenRouter.AnthropicImageBlockParamSourceVariant2?>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
            else if (IsUrl)
            {
                url?.Invoke(Url!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1),
                Url,
                typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant2),
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
        public bool Equals(AnthropicImageBlockParamSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicImageBlockParamSourceVariant1?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicImageBlockParamSourceVariant2?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicImageBlockParamSource obj1, AnthropicImageBlockParamSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicImageBlockParamSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicImageBlockParamSource obj1, AnthropicImageBlockParamSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicImageBlockParamSource o && Equals(o);
        }
    }
}
