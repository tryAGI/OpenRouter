
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopServerToolsWhenMaxCostType
    {
        /// <summary>
        /// 
        /// </summary>
        MaxCost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopServerToolsWhenMaxCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopServerToolsWhenMaxCostType value)
        {
            return value switch
            {
                StopServerToolsWhenMaxCostType.MaxCost => "max_cost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopServerToolsWhenMaxCostType? ToEnum(string value)
        {
            return value switch
            {
                "max_cost" => StopServerToolsWhenMaxCostType.MaxCost,
                _ => null,
            };
        }
    }
}