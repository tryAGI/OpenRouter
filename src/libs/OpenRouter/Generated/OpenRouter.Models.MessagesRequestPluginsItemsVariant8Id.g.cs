
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: response-healing
    /// </summary>
    public enum MessagesRequestPluginsItemsVariant8Id
    {
        /// <summary>
        /// response-healing
        /// </summary>
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsVariant8IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsVariant8Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsVariant8Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsVariant8Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => MessagesRequestPluginsItemsVariant8Id.ResponseHealing,
                _ => null,
            };
        }
    }
}