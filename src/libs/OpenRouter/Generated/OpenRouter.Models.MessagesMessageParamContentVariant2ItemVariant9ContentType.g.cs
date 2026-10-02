
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant9ContentType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant9ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant9ContentType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant9ContentType.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant9ContentType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => MessagesMessageParamContentVariant2ItemVariant9ContentType.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}