
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: context-compression
    /// </summary>
    public enum ChatRequestPluginsItemsVariant2Id
    {
        /// <summary>
        /// context-compression
        /// </summary>
        ContextCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsVariant2IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsVariant2Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsVariant2Id.ContextCompression => "context-compression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsVariant2Id? ToEnum(string value)
        {
            return value switch
            {
                "context-compression" => ChatRequestPluginsItemsVariant2Id.ContextCompression,
                _ => null,
            };
        }
    }
}