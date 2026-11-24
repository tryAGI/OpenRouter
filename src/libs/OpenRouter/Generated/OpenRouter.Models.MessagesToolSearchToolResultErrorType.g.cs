
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesToolSearchToolResultErrorType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesToolSearchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesToolSearchToolResultErrorType value)
        {
            return value switch
            {
                MessagesToolSearchToolResultErrorType.ToolSearchToolResultError => "tool_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesToolSearchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result_error" => MessagesToolSearchToolResultErrorType.ToolSearchToolResultError,
                _ => null,
            };
        }
    }
}