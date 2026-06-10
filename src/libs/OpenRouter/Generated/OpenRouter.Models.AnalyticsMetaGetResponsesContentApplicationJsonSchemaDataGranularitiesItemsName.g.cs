
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Granularity identifier
    /// </summary>
    public enum AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Minute,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName value)
        {
            return value switch
            {
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Day => "day",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Hour => "hour",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Minute => "minute",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Month => "month",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName? ToEnum(string value)
        {
            return value switch
            {
                "day" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Day,
                "hour" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Hour,
                "minute" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Minute,
                "month" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Month,
                "week" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName.Week,
                _ => null,
            };
        }
    }
}