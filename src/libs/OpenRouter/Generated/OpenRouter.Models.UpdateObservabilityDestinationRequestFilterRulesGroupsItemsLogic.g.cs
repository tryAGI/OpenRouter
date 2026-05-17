
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: and
    /// </summary>
    public enum UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic
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
    public static class UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic value)
        {
            return value switch
            {
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic.And => "and",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic? ToEnum(string value)
        {
            return value switch
            {
                "and" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic.And,
                "or" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic.Or,
                _ => null,
            };
        }
    }
}