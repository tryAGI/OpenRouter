#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicWebFetchContent : global::System.IEquatable<AnthropicWebFetchContent>
    {
        /// <summary>
        /// web_fetch_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchContentVariant1? WebFetchResult { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchContentVariant1? WebFetchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchResult))]
#endif
        public bool IsWebFetchResult => WebFetchResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebFetchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicWebFetchContentVariant1? value)
        {
            value = WebFetchResult;
            return IsWebFetchResult;
        }

        /// <summary>
        /// web_fetch_tool_result_error variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchContentVariant2? WebFetchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchContentVariant2? WebFetchToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchToolResultError))]
#endif
        public bool IsWebFetchToolResultError => WebFetchToolResultError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebFetchToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicWebFetchContentVariant2? value)
        {
            value = WebFetchToolResultError;
            return IsWebFetchToolResultError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchContentVariant1 value) => new AnthropicWebFetchContent((global::OpenRouter.AnthropicWebFetchContentVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchContentVariant1?(AnthropicWebFetchContent @this) => @this.WebFetchResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchContentVariant1? value)
        {
            WebFetchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchContentVariant2 value) => new AnthropicWebFetchContent((global::OpenRouter.AnthropicWebFetchContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchContentVariant2?(AnthropicWebFetchContent @this) => @this.WebFetchToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchContentVariant2? value)
        {
            WebFetchToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebFetchContent(
            global::OpenRouter.AnthropicWebFetchContentVariant1? webFetchResult,
            global::OpenRouter.AnthropicWebFetchContentVariant2? webFetchToolResultError
            )
        {
            WebFetchResult = webFetchResult;
            WebFetchToolResultError = webFetchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebFetchToolResultError as object ??
            WebFetchResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebFetchResult?.ToString() ??
            WebFetchToolResultError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebFetchResult && !IsWebFetchToolResultError || !IsWebFetchResult && IsWebFetchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicWebFetchContentVariant1, TResult>? webFetchResult = null,
            global::System.Func<global::OpenRouter.AnthropicWebFetchContentVariant2, TResult>? webFetchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebFetchResult && webFetchResult != null)
            {
                return webFetchResult(WebFetchResult!);
            }
            else if (IsWebFetchToolResultError && webFetchToolResultError != null)
            {
                return webFetchToolResultError(WebFetchToolResultError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicWebFetchContentVariant1>? webFetchResult = null,

            global::System.Action<global::OpenRouter.AnthropicWebFetchContentVariant2>? webFetchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebFetchResult)
            {
                webFetchResult?.Invoke(WebFetchResult!);
            }
            else if (IsWebFetchToolResultError)
            {
                webFetchToolResultError?.Invoke(WebFetchToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicWebFetchContentVariant1>? webFetchResult = null,
            global::System.Action<global::OpenRouter.AnthropicWebFetchContentVariant2>? webFetchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebFetchResult)
            {
                webFetchResult?.Invoke(WebFetchResult!);
            }
            else if (IsWebFetchToolResultError)
            {
                webFetchToolResultError?.Invoke(WebFetchToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebFetchResult,
                typeof(global::OpenRouter.AnthropicWebFetchContentVariant1),
                WebFetchToolResultError,
                typeof(global::OpenRouter.AnthropicWebFetchContentVariant2),
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
        public bool Equals(AnthropicWebFetchContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchContentVariant1?>.Default.Equals(WebFetchResult, other.WebFetchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchContentVariant2?>.Default.Equals(WebFetchToolResultError, other.WebFetchToolResultError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicWebFetchContent obj1, AnthropicWebFetchContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicWebFetchContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicWebFetchContent obj1, AnthropicWebFetchContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicWebFetchContent o && Equals(o);
        }
    }
}
