
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: auto-router
    /// </summary>
    public enum ChatRequestPluginsItemsVariant2Id
    {
        /// <summary>
        /// auto-router
        /// </summary>
        AutoRouter,
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
                ChatRequestPluginsItemsVariant2Id.AutoRouter => "auto-router",
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
                "auto-router" => ChatRequestPluginsItemsVariant2Id.AutoRouter,
                _ => null,
            };
        }
    }
}