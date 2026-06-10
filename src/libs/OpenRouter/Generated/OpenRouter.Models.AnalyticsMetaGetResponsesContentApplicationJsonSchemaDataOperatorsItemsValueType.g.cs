
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Whether the operator expects a single value or an array
    /// </summary>
    public enum AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Scalar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType value)
        {
            return value switch
            {
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType.Array => "array",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType.Scalar => "scalar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType? ToEnum(string value)
        {
            return value switch
            {
                "array" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType.Array,
                "scalar" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType.Scalar,
                _ => null,
            };
        }
    }
}