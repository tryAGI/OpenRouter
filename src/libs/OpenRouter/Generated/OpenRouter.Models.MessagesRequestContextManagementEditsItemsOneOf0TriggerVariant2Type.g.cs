
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: tool_uses
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type
    {
        /// <summary>
        /// tool_uses
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type.ToolUses,
                _ => null,
            };
        }
    }
}