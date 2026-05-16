
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: and
    /// </summary>
    public enum ObservabilityFilterRulesConfigGroupsItemsLogic
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
    public static class ObservabilityFilterRulesConfigGroupsItemsLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRulesConfigGroupsItemsLogic value)
        {
            return value switch
            {
                ObservabilityFilterRulesConfigGroupsItemsLogic.And => "and",
                ObservabilityFilterRulesConfigGroupsItemsLogic.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRulesConfigGroupsItemsLogic? ToEnum(string value)
        {
            return value switch
            {
                "and" => ObservabilityFilterRulesConfigGroupsItemsLogic.And,
                "or" => ObservabilityFilterRulesConfigGroupsItemsLogic.Or,
                _ => null,
            };
        }
    }
}