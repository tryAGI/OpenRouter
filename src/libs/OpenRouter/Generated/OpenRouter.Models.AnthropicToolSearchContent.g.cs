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
        /// tool_search_tool_result_error variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchContentVariant1? ToolSearchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchContentVariant1? ToolSearchToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolResultError))]
#endif
        public bool IsToolSearchToolResultError => ToolSearchToolResultError != null;

        /// <summary>
        /// tool_search_tool_search_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchContentVariant2? ToolSearchToolSearchResult { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchContentVariant2? ToolSearchToolSearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolSearchResult))]
#endif
        public bool IsToolSearchToolSearchResult => ToolSearchToolSearchResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchContentVariant1 value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchContentVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchContentVariant1?(AnthropicToolSearchContent @this) => @this.ToolSearchToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchContentVariant1? value)
        {
            ToolSearchToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchContentVariant2 value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchContentVariant2?(AnthropicToolSearchContent @this) => @this.ToolSearchToolSearchResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchContentVariant2? value)
        {
            ToolSearchToolSearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicToolSearchContent(
            global::OpenRouter.AnthropicToolSearchContentVariant1? toolSearchToolResultError,
            global::OpenRouter.AnthropicToolSearchContentVariant2? toolSearchToolSearchResult
            )
        {
            ToolSearchToolResultError = toolSearchToolResultError;
            ToolSearchToolSearchResult = toolSearchToolSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolSearchToolSearchResult as object ??
            ToolSearchToolResultError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolSearchToolResultError?.ToString() ??
            ToolSearchToolSearchResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolSearchToolResultError && !IsToolSearchToolSearchResult || !IsToolSearchToolResultError && IsToolSearchToolSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicToolSearchContentVariant1?, TResult>? toolSearchToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicToolSearchContentVariant2?, TResult>? toolSearchToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolSearchToolResultError && toolSearchToolResultError != null)
            {
                return toolSearchToolResultError(ToolSearchToolResultError!);
            }
            else if (IsToolSearchToolSearchResult && toolSearchToolSearchResult != null)
            {
                return toolSearchToolSearchResult(ToolSearchToolSearchResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicToolSearchContentVariant1?>? toolSearchToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicToolSearchContentVariant2?>? toolSearchToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolSearchToolResultError)
            {
                toolSearchToolResultError?.Invoke(ToolSearchToolResultError!);
            }
            else if (IsToolSearchToolSearchResult)
            {
                toolSearchToolSearchResult?.Invoke(ToolSearchToolSearchResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolSearchToolResultError,
                typeof(global::OpenRouter.AnthropicToolSearchContentVariant1),
                ToolSearchToolSearchResult,
                typeof(global::OpenRouter.AnthropicToolSearchContentVariant2),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchContentVariant1?>.Default.Equals(ToolSearchToolResultError, other.ToolSearchToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchContentVariant2?>.Default.Equals(ToolSearchToolSearchResult, other.ToolSearchToolSearchResult) 
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
