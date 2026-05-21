
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum RoutingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Alias,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Bodybuilder,
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Fallback,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Fusion,
        /// <summary>
        /// 
        /// </summary>
        Latest,
        /// <summary>
        /// 
        /// </summary>
        Pareto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoutingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingStrategy value)
        {
            return value switch
            {
                RoutingStrategy.Alias => "alias",
                RoutingStrategy.Auto => "auto",
                RoutingStrategy.Bodybuilder => "bodybuilder",
                RoutingStrategy.Direct => "direct",
                RoutingStrategy.Fallback => "fallback",
                RoutingStrategy.Free => "free",
                RoutingStrategy.Fusion => "fusion",
                RoutingStrategy.Latest => "latest",
                RoutingStrategy.Pareto => "pareto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "alias" => RoutingStrategy.Alias,
                "auto" => RoutingStrategy.Auto,
                "bodybuilder" => RoutingStrategy.Bodybuilder,
                "direct" => RoutingStrategy.Direct,
                "fallback" => RoutingStrategy.Fallback,
                "free" => RoutingStrategy.Free,
                "fusion" => RoutingStrategy.Fusion,
                "latest" => RoutingStrategy.Latest,
                "pareto" => RoutingStrategy.Pareto,
                _ => null,
            };
        }
    }
}