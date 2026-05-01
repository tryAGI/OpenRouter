
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_tokens
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type
    {
        /// <summary>
        /// input_tokens
        /// </summary>
        InputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type.InputTokens => "input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type.InputTokens,
                _ => null,
            };
        }
    }
}