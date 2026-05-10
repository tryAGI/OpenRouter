
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType
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
    public static class MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType.InputTokens => "input_tokens",
                MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType.InputTokens,
                "tool_uses" => MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType.ToolUses,
                _ => null,
            };
        }
    }
}