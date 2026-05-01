
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: auto-router
    /// </summary>
    public enum MessagesRequestPluginsItemsVariant1Id
    {
        /// <summary>
        /// auto-router
        /// </summary>
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsVariant1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsVariant1Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsVariant1Id.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsVariant1Id? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => MessagesRequestPluginsItemsVariant1Id.AutoRouter,
                _ => null,
            };
        }
    }
}