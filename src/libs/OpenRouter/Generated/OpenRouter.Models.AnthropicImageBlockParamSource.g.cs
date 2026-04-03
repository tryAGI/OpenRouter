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
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBase64ImageSource? AnthropicBase64ImageSource { get; init; }
#else
        public global::OpenRouter.AnthropicBase64ImageSource? AnthropicBase64ImageSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBase64ImageSource))]
#endif
        public bool IsAnthropicBase64ImageSource => AnthropicBase64ImageSource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchSource? WebSearchSource { get; init; }
#else
        public global::OpenRouter.WebSearchSource? WebSearchSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchSource))]
#endif
        public bool IsWebSearchSource => WebSearchSource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicImageBlockParamSource(global::OpenRouter.AnthropicBase64ImageSource value) => new AnthropicImageBlockParamSource((global::OpenRouter.AnthropicBase64ImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBase64ImageSource?(AnthropicImageBlockParamSource @this) => @this.AnthropicBase64ImageSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(global::OpenRouter.AnthropicBase64ImageSource? value)
        {
            AnthropicBase64ImageSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicImageBlockParamSource(global::OpenRouter.WebSearchSource value) => new AnthropicImageBlockParamSource((global::OpenRouter.WebSearchSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchSource?(AnthropicImageBlockParamSource @this) => @this.WebSearchSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(global::OpenRouter.WebSearchSource? value)
        {
            WebSearchSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(
            global::OpenRouter.AnthropicBase64ImageSource? anthropicBase64ImageSource,
            global::OpenRouter.WebSearchSource? webSearchSource
            )
        {
            AnthropicBase64ImageSource = anthropicBase64ImageSource;
            WebSearchSource = webSearchSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchSource as object ??
            AnthropicBase64ImageSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBase64ImageSource?.ToString() ??
            WebSearchSource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBase64ImageSource && !IsWebSearchSource || !IsAnthropicBase64ImageSource && IsWebSearchSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBase64ImageSource?, TResult>? anthropicBase64ImageSource = null,
            global::System.Func<global::OpenRouter.WebSearchSource?, TResult>? webSearchSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBase64ImageSource && anthropicBase64ImageSource != null)
            {
                return anthropicBase64ImageSource(AnthropicBase64ImageSource!);
            }
            else if (IsWebSearchSource && webSearchSource != null)
            {
                return webSearchSource(WebSearchSource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBase64ImageSource?>? anthropicBase64ImageSource = null,
            global::System.Action<global::OpenRouter.WebSearchSource?>? webSearchSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBase64ImageSource)
            {
                anthropicBase64ImageSource?.Invoke(AnthropicBase64ImageSource!);
            }
            else if (IsWebSearchSource)
            {
                webSearchSource?.Invoke(WebSearchSource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicBase64ImageSource,
                typeof(global::OpenRouter.AnthropicBase64ImageSource),
                WebSearchSource,
                typeof(global::OpenRouter.WebSearchSource),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBase64ImageSource?>.Default.Equals(AnthropicBase64ImageSource, other.AnthropicBase64ImageSource) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchSource?>.Default.Equals(WebSearchSource, other.WebSearchSource) 
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
