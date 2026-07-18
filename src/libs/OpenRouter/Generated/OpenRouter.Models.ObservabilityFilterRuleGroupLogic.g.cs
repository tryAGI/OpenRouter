
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: and
    /// </summary>
    public enum ObservabilityFilterRuleGroupLogic
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityFilterRuleGroupLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRuleGroupLogic value)
        {
            return value switch
            {
                ObservabilityFilterRuleGroupLogic.And => "and",
                ObservabilityFilterRuleGroupLogic.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRuleGroupLogic? ToEnum(string value)
        {
            return value switch
            {
                "and" => ObservabilityFilterRuleGroupLogic.And,
                "or" => ObservabilityFilterRuleGroupLogic.Or,
                _ => null,
            };
        }
    }
}