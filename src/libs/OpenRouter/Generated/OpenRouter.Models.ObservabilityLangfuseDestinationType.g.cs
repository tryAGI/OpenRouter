
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityLangfuseDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityLangfuseDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityLangfuseDestinationType value)
        {
            return value switch
            {
                ObservabilityLangfuseDestinationType.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityLangfuseDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => ObservabilityLangfuseDestinationType.Langfuse,
                _ => null,
            };
        }
    }
}