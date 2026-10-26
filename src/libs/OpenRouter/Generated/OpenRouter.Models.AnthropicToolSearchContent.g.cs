#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
    /// </summary>
    public readonly partial struct AnthropicToolSearchContent : global::System.IEquatable<AnthropicToolSearchContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"error_code":"unavailable","error_message":null,"type":"tool_search_tool_result_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchResultError? ToolSearchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchResultError? ToolSearchToolResultError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolResultError))]
#endif
        public bool IsToolSearchToolResultError => ToolSearchToolResultError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearchToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolSearchResultError? value)
        {
            value = ToolSearchToolResultError;
            return IsToolSearchToolResultError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultError PickToolSearchToolResultError() => ToolSearchToolResultError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResultError' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchResult? ToolSearchToolSearchResult { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchResult? ToolSearchToolSearchResult { get; }
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
        public bool TryPickToolSearchToolSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolSearchResult? value)
        {
            value = ToolSearchToolSearchResult;
            return IsToolSearchToolSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResult PickToolSearchToolSearchResult() => ToolSearchToolSearchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolSearchResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResultError value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchResultError?(AnthropicToolSearchContent @this) => @this.ToolSearchToolResultError;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResultError? value)
        {
            ToolSearchToolResultError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchContent FromToolSearchToolResultError(global::OpenRouter.AnthropicToolSearchResultError? value) => new AnthropicToolSearchContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResult value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchResult?(AnthropicToolSearchContent @this) => @this.ToolSearchToolSearchResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResult? value)
        {
            ToolSearchToolSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchContent FromToolSearchToolSearchResult(global::OpenRouter.AnthropicToolSearchResult? value) => new AnthropicToolSearchContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchContent(
            global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? type,
            global::OpenRouter.AnthropicToolSearchResultError? toolSearchToolResultError,
            global::OpenRouter.AnthropicToolSearchResult? toolSearchToolSearchResult
            )
        {
            Type = type;

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
            global::System.Func<global::OpenRouter.AnthropicToolSearchResultError, TResult>? toolSearchToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicToolSearchResult, TResult>? toolSearchToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ToolSearchToolResultError is { } __value0 && toolSearchToolResultError != null)
            {
                return toolSearchToolResultError(__value0);
            }
            else if (ToolSearchToolSearchResult is { } __value1 && toolSearchToolSearchResult != null)
            {
                return toolSearchToolSearchResult(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicToolSearchResultError>? toolSearchToolResultError = null,

            global::System.Action<global::OpenRouter.AnthropicToolSearchResult>? toolSearchToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ToolSearchToolResultError is { } __value0)
            {
                toolSearchToolResultError?.Invoke(__value0);
            }
            else if (ToolSearchToolSearchResult is { } __value1)
            {
                toolSearchToolSearchResult?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicToolSearchResultError>? toolSearchToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicToolSearchResult>? toolSearchToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ToolSearchToolResultError is { } __value0)
            {
                toolSearchToolResultError?.Invoke(__value0);
            }
            else if (ToolSearchToolSearchResult is { } __value1)
            {
                toolSearchToolSearchResult?.Invoke(__value1);
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
                typeof(global::OpenRouter.AnthropicToolSearchResultError),
                ToolSearchToolSearchResult,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchResultError?>.Default.Equals(ToolSearchToolResultError, other.ToolSearchToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchResult?>.Default.Equals(ToolSearchToolSearchResult, other.ToolSearchToolSearchResult)
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
