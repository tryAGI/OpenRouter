
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: auto-router
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant1Id
    {
        /// <summary>
        /// auto-router
        /// </summary>
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant1Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant1Id.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant1Id? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => ResponsesRequestPluginsItemsVariant1Id.AutoRouter,
                _ => null,
            };
        }
    }
}