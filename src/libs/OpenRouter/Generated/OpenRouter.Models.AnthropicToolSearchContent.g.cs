#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicToolSearchContent : global::System.IEquatable<AnthropicToolSearchContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchResultError? AnthropicToolSearchResultError { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchResultError? AnthropicToolSearchResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolSearchResultError))]
#endif
        public bool IsAnthropicToolSearchResultError => AnthropicToolSearchResultError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchResult? AnthropicToolSearchResult { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchResult? AnthropicToolSearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolSearchResult))]
#endif
        public bool IsAnthropicToolSearchResult => AnthropicToolSearchResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResultError value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchResultError?(AnthropicToolSearchContent @this) => @this.AnthropicToolSearchResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResultError? value)
        {
            AnthropicToolSearchResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResult value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchResult?(AnthropicToolSearchContent @this) => @this.AnthropicToolSearchResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResult? value)
        {
            AnthropicToolSearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicToolSearchContent(
            global::OpenRouter.AnthropicToolSearchResultError? anthropicToolSearchResultError,
            global::OpenRouter.AnthropicToolSearchResult? anthropicToolSearchResult
            )
        {
            AnthropicToolSearchResultError = anthropicToolSearchResultError;
            AnthropicToolSearchResult = anthropicToolSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicToolSearchResult as object ??
            AnthropicToolSearchResultError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicToolSearchResultError?.ToString() ??
            AnthropicToolSearchResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicToolSearchResultError && !IsAnthropicToolSearchResult || !IsAnthropicToolSearchResultError && IsAnthropicToolSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicToolSearchResultError?, TResult>? anthropicToolSearchResultError = null,
            global::System.Func<global::OpenRouter.AnthropicToolSearchResult?, TResult>? anthropicToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicToolSearchResultError && anthropicToolSearchResultError != null)
            {
                return anthropicToolSearchResultError(AnthropicToolSearchResultError!);
            }
            else if (IsAnthropicToolSearchResult && anthropicToolSearchResult != null)
            {
                return anthropicToolSearchResult(AnthropicToolSearchResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicToolSearchResultError?>? anthropicToolSearchResultError = null,
            global::System.Action<global::OpenRouter.AnthropicToolSearchResult?>? anthropicToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicToolSearchResultError)
            {
                anthropicToolSearchResultError?.Invoke(AnthropicToolSearchResultError!);
            }
            else if (IsAnthropicToolSearchResult)
            {
                anthropicToolSearchResult?.Invoke(AnthropicToolSearchResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicToolSearchResultError,
                typeof(global::OpenRouter.AnthropicToolSearchResultError),
                AnthropicToolSearchResult,
                typeof(global::OpenRouter.AnthropicToolSearchResult),
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
        public bool Equals(AnthropicToolSearchContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchResultError?>.Default.Equals(AnthropicToolSearchResultError, other.AnthropicToolSearchResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchResult?>.Default.Equals(AnthropicToolSearchResult, other.AnthropicToolSearchResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicToolSearchContent obj1, AnthropicToolSearchContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicToolSearchContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicToolSearchContent obj1, AnthropicToolSearchContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicToolSearchContent o && Equals(o);
        }
    }
}
