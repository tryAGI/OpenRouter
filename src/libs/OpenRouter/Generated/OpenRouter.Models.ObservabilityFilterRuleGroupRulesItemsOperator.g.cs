
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityFilterRuleGroupRulesItemsOperator
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
    public static class ObservabilityFilterRuleGroupRulesItemsOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRuleGroupRulesItemsOperator value)
        {
            return value switch
            {
                ObservabilityFilterRuleGroupRulesItemsOperator.Contains => "contains",
                ObservabilityFilterRuleGroupRulesItemsOperator.EndsWith => "ends_with",
                ObservabilityFilterRuleGroupRulesItemsOperator.Equals => "equals",
                ObservabilityFilterRuleGroupRulesItemsOperator.Exists => "exists",
                ObservabilityFilterRuleGroupRulesItemsOperator.Gt => "gt",
                ObservabilityFilterRuleGroupRulesItemsOperator.Gte => "gte",
                ObservabilityFilterRuleGroupRulesItemsOperator.Lt => "lt",
                ObservabilityFilterRuleGroupRulesItemsOperator.Lte => "lte",
                ObservabilityFilterRuleGroupRulesItemsOperator.NotContains => "not_contains",
                ObservabilityFilterRuleGroupRulesItemsOperator.NotEquals => "not_equals",
                ObservabilityFilterRuleGroupRulesItemsOperator.NotExists => "not_exists",
                ObservabilityFilterRuleGroupRulesItemsOperator.Regex => "regex",
                ObservabilityFilterRuleGroupRulesItemsOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRuleGroupRulesItemsOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => ObservabilityFilterRuleGroupRulesItemsOperator.Contains,
                "ends_with" => ObservabilityFilterRuleGroupRulesItemsOperator.EndsWith,
                "equals" => ObservabilityFilterRuleGroupRulesItemsOperator.Equals,
                "exists" => ObservabilityFilterRuleGroupRulesItemsOperator.Exists,
                "gt" => ObservabilityFilterRuleGroupRulesItemsOperator.Gt,
                "gte" => ObservabilityFilterRuleGroupRulesItemsOperator.Gte,
                "lt" => ObservabilityFilterRuleGroupRulesItemsOperator.Lt,
                "lte" => ObservabilityFilterRuleGroupRulesItemsOperator.Lte,
                "not_contains" => ObservabilityFilterRuleGroupRulesItemsOperator.NotContains,
                "not_equals" => ObservabilityFilterRuleGroupRulesItemsOperator.NotEquals,
                "not_exists" => ObservabilityFilterRuleGroupRulesItemsOperator.NotExists,
                "regex" => ObservabilityFilterRuleGroupRulesItemsOperator.Regex,
                "starts_with" => ObservabilityFilterRuleGroupRulesItemsOperator.StartsWith,
                _ => null,
            };
        }
    }
}