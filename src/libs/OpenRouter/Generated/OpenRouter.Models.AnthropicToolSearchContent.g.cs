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
        public global::OpenRouter.AnthropicToolSearchResultError? ToolSearchToolResultError1 { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchResultError? ToolSearchToolResultError1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolResultError1))]
#endif
        public bool IsToolSearchToolResultError1 => ToolSearchToolResultError1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearchToolResultError1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolSearchResultError? value)
        {
            value = ToolSearchToolResultError1;
            return IsToolSearchToolResultError1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultError PickToolSearchToolResultError1() => ToolSearchToolResultError1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResultError1' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchResult? ToolSearchToolResultError2 { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchResult? ToolSearchToolResultError2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolResultError2))]
#endif
        public bool IsToolSearchToolResultError2 => ToolSearchToolResultError2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearchToolResultError2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolSearchResult? value)
        {
            value = ToolSearchToolResultError2;
            return IsToolSearchToolResultError2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResult PickToolSearchToolResultError2() => ToolSearchToolResultError2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResultError2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResultError value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchResultError?(AnthropicToolSearchContent @this) => @this.ToolSearchToolResultError1;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResultError? value)
        {
            ToolSearchToolResultError1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchContent FromToolSearchToolResultError1(global::OpenRouter.AnthropicToolSearchResultError? value) => new AnthropicToolSearchContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResult value) => new AnthropicToolSearchContent((global::OpenRouter.AnthropicToolSearchResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchResult?(AnthropicToolSearchContent @this) => @this.ToolSearchToolResultError2;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchContent(global::OpenRouter.AnthropicToolSearchResult? value)
        {
            ToolSearchToolResultError2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchContent FromToolSearchToolResultError2(global::OpenRouter.AnthropicToolSearchResult? value) => new AnthropicToolSearchContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchContent(
            global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? type,
            global::OpenRouter.AnthropicToolSearchResultError? toolSearchToolResultError1,
            global::OpenRouter.AnthropicToolSearchResult? toolSearchToolResultError2
            )
        {
            Type = type;

            ToolSearchToolResultError1 = toolSearchToolResultError1;
            ToolSearchToolResultError2 = toolSearchToolResultError2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ToolSearchToolResultError2 as object ??
            ToolSearchToolResultError1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ToolSearchToolResultError1?.ToString() ??
            ToolSearchToolResultError2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsToolSearchToolResultError1 && !IsToolSearchToolResultError2 || !IsToolSearchToolResultError1 && IsToolSearchToolResultError2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicToolSearchResultError, TResult>? toolSearchToolResultError1 = null,
            global::System.Func<global::OpenRouter.AnthropicToolSearchResult, TResult>? toolSearchToolResultError2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ToolSearchToolResultError1 is { } __value0 && toolSearchToolResultError1 != null)
            {
                return toolSearchToolResultError1(__value0);
            }
            else if (ToolSearchToolResultError2 is { } __value1 && toolSearchToolResultError2 != null)
            {
                return toolSearchToolResultError2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicToolSearchResultError>? toolSearchToolResultError1 = null,

            global::System.Action<global::OpenRouter.AnthropicToolSearchResult>? toolSearchToolResultError2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ToolSearchToolResultError1 is { } __value0)
            {
                toolSearchToolResultError1?.Invoke(__value0);
            }
            else if (ToolSearchToolResultError2 is { } __value1)
            {
                toolSearchToolResultError2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicToolSearchResultError>? toolSearchToolResultError1 = null,
            global::System.Action<global::OpenRouter.AnthropicToolSearchResult>? toolSearchToolResultError2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ToolSearchToolResultError1 is { } __value0)
            {
                toolSearchToolResultError1?.Invoke(__value0);
            }
            else if (ToolSearchToolResultError2 is { } __value1)
            {
                toolSearchToolResultError2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolSearchToolResultError1,
                typeof(global::OpenRouter.AnthropicToolSearchResultError),
                ToolSearchToolResultError2,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchResultError?>.Default.Equals(ToolSearchToolResultError1, other.ToolSearchToolResultError1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchResult?>.Default.Equals(ToolSearchToolResultError2, other.ToolSearchToolResultError2)
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
