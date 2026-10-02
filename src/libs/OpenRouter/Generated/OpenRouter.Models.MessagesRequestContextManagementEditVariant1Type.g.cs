
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestContextManagementEditVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        ClearToolUses20250919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditVariant1Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditVariant1Type.ClearToolUses20250919 => "clear_tool_uses_20250919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "clear_tool_uses_20250919" => MessagesRequestContextManagementEditVariant1Type.ClearToolUses20250919,
                _ => null,
            };
        }
    }
}