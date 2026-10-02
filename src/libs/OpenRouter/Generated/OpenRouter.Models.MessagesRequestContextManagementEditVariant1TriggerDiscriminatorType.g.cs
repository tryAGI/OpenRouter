
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputTokens,
        /// <summary>
        ///
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditVariant1TriggerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType.InputTokens => "input_tokens",
                MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType.InputTokens,
                "tool_uses" => MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType.ToolUses,
                _ => null,
            };
        }
    }
}