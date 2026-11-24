#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// What a tool search returned: the tools it found, or an error.<br/>
    /// Example: {"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
    /// </summary>
    public readonly partial struct MessagesToolSearchToolResultContent : global::System.IEquatable<MessagesToolSearchToolResultContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolSearchToolResultContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A tool search that returned an error in place of tools.<br/>
        /// Example: {"error_code":"unavailable","error_message":null,"type":"tool_search_tool_result_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesToolSearchToolResultError? ToolSearchToolResultError { get; init; }
#else
        public global::OpenRouter.MessagesToolSearchToolResultError? ToolSearchToolResultError { get; }
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
            out global::OpenRouter.MessagesToolSearchToolResultError? value)
        {
            value = ToolSearchToolResultError;
            return IsToolSearchToolResultError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolSearchToolResultError PickToolSearchToolResultError() => ToolSearchToolResultError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResultError' but the value was {ToString()}.");

        /// <summary>
        /// The tools a tool search found, by name, in match order.<br/>
        /// Example: {"tool_references":[{"tool_name":"get_weather","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesToolSearchToolSearchResult? ToolSearchToolSearchResult { get; init; }
#else
        public global::OpenRouter.MessagesToolSearchToolSearchResult? ToolSearchToolSearchResult { get; }
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
            out global::OpenRouter.MessagesToolSearchToolSearchResult? value)
        {
            value = ToolSearchToolSearchResult;
            return IsToolSearchToolSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolSearchToolSearchResult PickToolSearchToolSearchResult() => ToolSearchToolSearchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolSearchResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesToolSearchToolResultContent(global::OpenRouter.MessagesToolSearchToolResultError value) => new MessagesToolSearchToolResultContent((global::OpenRouter.MessagesToolSearchToolResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesToolSearchToolResultError?(MessagesToolSearchToolResultContent @this) => @this.ToolSearchToolResultError;

        /// <summary>
        ///
        /// </summary>
        public MessagesToolSearchToolResultContent(global::OpenRouter.MessagesToolSearchToolResultError? value)
        {
            ToolSearchToolResultError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesToolSearchToolResultContent FromToolSearchToolResultError(global::OpenRouter.MessagesToolSearchToolResultError? value) => new MessagesToolSearchToolResultContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesToolSearchToolResultContent(global::OpenRouter.MessagesToolSearchToolSearchResult value) => new MessagesToolSearchToolResultContent((global::OpenRouter.MessagesToolSearchToolSearchResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesToolSearchToolSearchResult?(MessagesToolSearchToolResultContent @this) => @this.ToolSearchToolSearchResult;

        /// <summary>
        ///
        /// </summary>
        public MessagesToolSearchToolResultContent(global::OpenRouter.MessagesToolSearchToolSearchResult? value)
        {
            ToolSearchToolSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesToolSearchToolResultContent FromToolSearchToolSearchResult(global::OpenRouter.MessagesToolSearchToolSearchResult? value) => new MessagesToolSearchToolResultContent(value);

        /// <summary>
        ///
        /// </summary>
        public MessagesToolSearchToolResultContent(
            global::OpenRouter.MessagesToolSearchToolResultContentDiscriminatorType? type,
            global::OpenRouter.MessagesToolSearchToolResultError? toolSearchToolResultError,
            global::OpenRouter.MessagesToolSearchToolSearchResult? toolSearchToolSearchResult
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
            global::System.Func<global::OpenRouter.MessagesToolSearchToolResultError, TResult>? toolSearchToolResultError = null,
            global::System.Func<global::OpenRouter.MessagesToolSearchToolSearchResult, TResult>? toolSearchToolSearchResult = null,
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
            global::System.Action<global::OpenRouter.MessagesToolSearchToolResultError>? toolSearchToolResultError = null,

            global::System.Action<global::OpenRouter.MessagesToolSearchToolSearchResult>? toolSearchToolSearchResult = null,
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
            global::System.Action<global::OpenRouter.MessagesToolSearchToolResultError>? toolSearchToolResultError = null,
            global::System.Action<global::OpenRouter.MessagesToolSearchToolSearchResult>? toolSearchToolSearchResult = null,
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
                typeof(global::OpenRouter.MessagesToolSearchToolResultError),
                ToolSearchToolSearchResult,
                typeof(global::OpenRouter.MessagesToolSearchToolSearchResult),
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
        public bool Equals(MessagesToolSearchToolResultContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesToolSearchToolResultError?>.Default.Equals(ToolSearchToolResultError, other.ToolSearchToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesToolSearchToolSearchResult?>.Default.Equals(ToolSearchToolSearchResult, other.ToolSearchToolSearchResult)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MessagesToolSearchToolResultContent obj1, MessagesToolSearchToolResultContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesToolSearchToolResultContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesToolSearchToolResultContent obj1, MessagesToolSearchToolResultContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesToolSearchToolResultContent o && Equals(o);
        }
    }
}
