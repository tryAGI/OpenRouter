
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityLangsmithDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Langsmith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityLangsmithDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityLangsmithDestinationType value)
        {
            return value switch
            {
                ObservabilityLangsmithDestinationType.Langsmith => "langsmith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityLangsmithDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "langsmith" => ObservabilityLangsmithDestinationType.Langsmith,
                _ => null,
            };
        }
    }
}