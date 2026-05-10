
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolSearchContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolResultError,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchContentDiscriminatorType value)
        {
            return value switch
            {
                AnthropicToolSearchContentDiscriminatorType.ToolSearchToolResultError => "tool_search_tool_result_error",
                AnthropicToolSearchContentDiscriminatorType.ToolSearchToolSearchResult => "tool_search_tool_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result_error" => AnthropicToolSearchContentDiscriminatorType.ToolSearchToolResultError,
                "tool_search_tool_search_result" => AnthropicToolSearchContentDiscriminatorType.ToolSearchToolSearchResult,
                _ => null,
            };
        }
    }
}