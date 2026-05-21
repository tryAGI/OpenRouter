
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: pareto-router
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant6Id
    {
        /// <summary>
        /// pareto-router
        /// </summary>
        ParetoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant6IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant6Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant6Id.ParetoRouter => "pareto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant6Id? ToEnum(string value)
        {
            return value switch
            {
                "pareto-router" => ResponsesRequestPluginsItemsVariant6Id.ParetoRouter,
                _ => null,
            };
        }
    }
}