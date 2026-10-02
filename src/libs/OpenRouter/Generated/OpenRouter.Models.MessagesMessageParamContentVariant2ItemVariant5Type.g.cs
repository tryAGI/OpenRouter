
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant5Type value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant5Type.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => MessagesMessageParamContentVariant2ItemVariant5Type.ToolResult,
                _ => null,
            };
        }
    }
}