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
        public global::OpenRouter.AnthropicUrlImageSource? AnthropicUrlImageSource { get; init; }
#else
        public global::OpenRouter.AnthropicUrlImageSource? AnthropicUrlImageSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicUrlImageSource))]
#endif
        public bool IsAnthropicUrlImageSource => AnthropicUrlImageSource != null;
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
        public static implicit operator AnthropicImageBlockParamSource(global::OpenRouter.AnthropicUrlImageSource value) => new AnthropicImageBlockParamSource((global::OpenRouter.AnthropicUrlImageSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicUrlImageSource?(AnthropicImageBlockParamSource @this) => @this.AnthropicUrlImageSource;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(global::OpenRouter.AnthropicUrlImageSource? value)
        {
            AnthropicUrlImageSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicImageBlockParamSource(
            global::OpenRouter.AnthropicBase64ImageSource? anthropicBase64ImageSource,
            global::OpenRouter.AnthropicUrlImageSource? anthropicUrlImageSource
            )
        {
            AnthropicBase64ImageSource = anthropicBase64ImageSource;
            AnthropicUrlImageSource = anthropicUrlImageSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicUrlImageSource as object ??
            AnthropicBase64ImageSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBase64ImageSource?.ToString() ??
            AnthropicUrlImageSource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBase64ImageSource && !IsAnthropicUrlImageSource || !IsAnthropicBase64ImageSource && IsAnthropicUrlImageSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBase64ImageSource?, TResult>? anthropicBase64ImageSource = null,
            global::System.Func<global::OpenRouter.AnthropicUrlImageSource?, TResult>? anthropicUrlImageSource = null,
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
            else if (IsAnthropicUrlImageSource && anthropicUrlImageSource != null)
            {
                return anthropicUrlImageSource(AnthropicUrlImageSource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBase64ImageSource?>? anthropicBase64ImageSource = null,
            global::System.Action<global::OpenRouter.AnthropicUrlImageSource?>? anthropicUrlImageSource = null,
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
            else if (IsAnthropicUrlImageSource)
            {
                anthropicUrlImageSource?.Invoke(AnthropicUrlImageSource!);
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
                AnthropicUrlImageSource,
                typeof(global::OpenRouter.AnthropicUrlImageSource),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicUrlImageSource?>.Default.Equals(AnthropicUrlImageSource, other.AnthropicUrlImageSource) 
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
