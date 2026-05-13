
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: response-healing
    /// </summary>
    public enum MessagesRequestPluginsItemsVariant7Id
    {
        /// <summary>
        /// response-healing
        /// </summary>
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsVariant7IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsVariant7Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsVariant7Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsVariant7Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => MessagesRequestPluginsItemsVariant7Id.ResponseHealing,
                _ => null,
            };
        }
    }
}