
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: newrelic
    /// </summary>
    public enum ObservabilityDestinationVariant8Type
    {
        /// <summary>
        /// newrelic
        /// </summary>
        Newrelic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant8Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant8Type.Newrelic => "newrelic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "newrelic" => ObservabilityDestinationVariant8Type.Newrelic,
                _ => null,
            };
        }
    }
}