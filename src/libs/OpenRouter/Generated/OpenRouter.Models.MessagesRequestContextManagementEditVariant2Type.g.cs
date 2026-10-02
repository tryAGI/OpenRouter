
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestContextManagementEditVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        ClearThinking20251015,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditVariant2Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditVariant2Type.ClearThinking20251015 => "clear_thinking_20251015",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "clear_thinking_20251015" => MessagesRequestContextManagementEditVariant2Type.ClearThinking20251015,
                _ => null,
            };
        }
    }
}