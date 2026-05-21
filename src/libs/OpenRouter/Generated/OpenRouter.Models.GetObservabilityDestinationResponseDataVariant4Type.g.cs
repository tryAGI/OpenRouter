
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: datadog
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant4Type
    {
        /// <summary>
        /// datadog
        /// </summary>
        Datadog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant4Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant4Type.Datadog => "datadog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "datadog" => GetObservabilityDestinationResponseDataVariant4Type.Datadog,
                _ => null,
            };
        }
    }
}