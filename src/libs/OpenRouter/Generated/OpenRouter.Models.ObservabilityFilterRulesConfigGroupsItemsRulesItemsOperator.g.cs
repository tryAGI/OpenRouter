
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator
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
    public static class ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator value)
        {
            return value switch
            {
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Contains => "contains",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.EndsWith => "ends_with",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Equals => "equals",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Exists => "exists",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Gt => "gt",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Gte => "gte",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Lt => "lt",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Lte => "lte",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.NotContains => "not_contains",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.NotEquals => "not_equals",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.NotExists => "not_exists",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Regex => "regex",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Contains,
                "ends_with" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.EndsWith,
                "equals" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Equals,
                "exists" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Exists,
                "gt" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Gt,
                "gte" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Gte,
                "lt" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Lt,
                "lte" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Lte,
                "not_contains" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.NotContains,
                "not_equals" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.NotEquals,
                "not_exists" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.NotExists,
                "regex" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.Regex,
                "starts_with" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsOperator.StartsWith,
                _ => null,
            };
        }
    }
}