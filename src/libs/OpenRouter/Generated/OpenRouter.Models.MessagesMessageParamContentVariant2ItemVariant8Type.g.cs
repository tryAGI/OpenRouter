
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant8Type
    {
        /// <summary>
        ///
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant8Type value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant8Type.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => MessagesMessageParamContentVariant2ItemVariant8Type.ServerToolUse,
                _ => null,
            };
        }
    }
}