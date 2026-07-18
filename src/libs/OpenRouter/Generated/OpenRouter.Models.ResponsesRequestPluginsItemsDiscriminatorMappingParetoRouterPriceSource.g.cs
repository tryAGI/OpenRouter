
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Price source for the Pareto frontier cost axis. "prompt" uses catalog list price (endpoint.pricing.prompt). "weighted_avg" uses traffic-weighted effective input price from ClickHouse, falling back to prompt price for models without traffic data. Defaults to "prompt".
    /// </summary>
    public enum ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        WeightedAvg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource.Prompt => "prompt",
                ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource.WeightedAvg => "weighted_avg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource.Prompt,
                "weighted_avg" => ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource.WeightedAvg,
                _ => null,
            };
        }
    }
}