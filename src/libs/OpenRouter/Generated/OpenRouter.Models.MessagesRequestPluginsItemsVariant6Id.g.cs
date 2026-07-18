
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: moderation
    /// </summary>
    public enum MessagesRequestPluginsItemsVariant6Id
    {
        /// <summary>
        /// moderation
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsVariant6IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsVariant6Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsVariant6Id.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsVariant6Id? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => MessagesRequestPluginsItemsVariant6Id.Moderation,
                _ => null,
            };
        }
    }
}