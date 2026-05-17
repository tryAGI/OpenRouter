
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        Exists,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotEquals,
        /// <summary>
        /// 
        /// </summary>
        NotExists,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator value)
        {
            return value switch
            {
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Contains => "contains",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.EndsWith => "ends_with",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Equals => "equals",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Exists => "exists",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Gt => "gt",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Gte => "gte",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Lt => "lt",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Lte => "lte",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.NotContains => "not_contains",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.NotEquals => "not_equals",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.NotExists => "not_exists",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Regex => "regex",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Contains,
                "ends_with" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.EndsWith,
                "equals" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Equals,
                "exists" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Exists,
                "gt" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Gt,
                "gte" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Gte,
                "lt" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Lt,
                "lte" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Lte,
                "not_contains" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.NotContains,
                "not_equals" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.NotEquals,
                "not_exists" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.NotExists,
                "regex" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.Regex,
                "starts_with" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator.StartsWith,
                _ => null,
            };
        }
    }
}