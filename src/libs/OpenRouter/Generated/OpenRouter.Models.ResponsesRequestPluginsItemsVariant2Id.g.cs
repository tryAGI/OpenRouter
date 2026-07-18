
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: auto-router
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant2Id
    {
        /// <summary>
        /// auto-router
        /// </summary>
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant2IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant2Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant2Id.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant2Id? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => ResponsesRequestPluginsItemsVariant2Id.AutoRouter,
                _ => null,
            };
        }
    }
}