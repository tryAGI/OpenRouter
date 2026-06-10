
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection value)
        {
            return value switch
            {
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection.Asc => "asc",
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection.Asc,
                "desc" => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection.Desc,
                _ => null,
            };
        }
    }
}