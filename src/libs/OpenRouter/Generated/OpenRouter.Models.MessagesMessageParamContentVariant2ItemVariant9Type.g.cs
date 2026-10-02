
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant9Type
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant9Type value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant9Type.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => MessagesMessageParamContentVariant2ItemVariant9Type.WebSearchToolResult,
                _ => null,
            };
        }
    }
}