
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: auto-beta-router
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant1Id
    {
        /// <summary>
        /// auto-beta-router
        /// </summary>
        AutoBetaRouter,
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
                ResponsesRequestPluginsItemsVariant1Id.AutoBetaRouter => "auto-beta-router",
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
                "auto-beta-router" => ResponsesRequestPluginsItemsVariant1Id.AutoBetaRouter,
                _ => null,
            };
        }
    }
}