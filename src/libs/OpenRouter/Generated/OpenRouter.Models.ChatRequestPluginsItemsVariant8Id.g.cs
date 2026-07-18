
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: response-healing
    /// </summary>
    public enum ChatRequestPluginsItemsVariant8Id
    {
        /// <summary>
        /// response-healing
        /// </summary>
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsVariant8IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsVariant8Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsVariant8Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsVariant8Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => ChatRequestPluginsItemsVariant8Id.ResponseHealing,
                _ => null,
            };
        }
    }
}