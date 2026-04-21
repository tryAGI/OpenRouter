
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParetoRouterPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        ParetoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParetoRouterPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParetoRouterPluginId value)
        {
            return value switch
            {
                ParetoRouterPluginId.ParetoRouter => "pareto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParetoRouterPluginId? ToEnum(string value)
        {
            return value switch
            {
                "pareto-router" => ParetoRouterPluginId.ParetoRouter,
                _ => null,
            };
        }
    }
}