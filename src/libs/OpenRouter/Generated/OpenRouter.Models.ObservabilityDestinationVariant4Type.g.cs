
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: datadog
    /// </summary>
    public enum ObservabilityDestinationVariant4Type
    {
        /// <summary>
        /// datadog
        /// </summary>
        Datadog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant4Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant4Type.Datadog => "datadog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "datadog" => ObservabilityDestinationVariant4Type.Datadog,
                _ => null,
            };
        }
    }
}