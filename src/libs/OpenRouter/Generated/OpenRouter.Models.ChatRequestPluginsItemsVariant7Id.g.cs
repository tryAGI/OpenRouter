
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: pareto-router
    /// </summary>
    public enum ChatRequestPluginsItemsVariant7Id
    {
        /// <summary>
        /// pareto-router
        /// </summary>
        ParetoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsVariant7IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsVariant7Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsVariant7Id.ParetoRouter => "pareto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsVariant7Id? ToEnum(string value)
        {
            return value switch
            {
                "pareto-router" => ChatRequestPluginsItemsVariant7Id.ParetoRouter,
                _ => null,
            };
        }
    }
}