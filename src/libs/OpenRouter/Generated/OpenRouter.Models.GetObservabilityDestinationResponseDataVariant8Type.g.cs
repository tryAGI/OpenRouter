
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: newrelic
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant8Type
    {
        /// <summary>
        /// newrelic
        /// </summary>
        Newrelic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant8Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant8Type.Newrelic => "newrelic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "newrelic" => GetObservabilityDestinationResponseDataVariant8Type.Newrelic,
                _ => null,
            };
        }
    }
}