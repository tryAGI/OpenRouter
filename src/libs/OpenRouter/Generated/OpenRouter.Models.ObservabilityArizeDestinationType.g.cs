
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ObservabilityArizeDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Arize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityArizeDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityArizeDestinationType value)
        {
            return value switch
            {
                ObservabilityArizeDestinationType.Arize => "arize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityArizeDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "arize" => ObservabilityArizeDestinationType.Arize,
                _ => null,
            };
        }
    }
}