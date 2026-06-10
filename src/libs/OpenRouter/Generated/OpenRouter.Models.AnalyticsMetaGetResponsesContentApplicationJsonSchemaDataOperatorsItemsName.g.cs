
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Operator identifier used in filter definitions
    /// </summary>
    public enum AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
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
        In,
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
        Neq,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName value)
        {
            return value switch
            {
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Eq => "eq",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Gt => "gt",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Gte => "gte",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.In => "in",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Lt => "lt",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Lte => "lte",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Neq => "neq",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Eq,
                "gt" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Gt,
                "gte" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Gte,
                "in" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.In,
                "lt" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Lt,
                "lte" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Lte,
                "neq" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.Neq,
                "not_in" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName.NotIn,
                _ => null,
            };
        }
    }
}