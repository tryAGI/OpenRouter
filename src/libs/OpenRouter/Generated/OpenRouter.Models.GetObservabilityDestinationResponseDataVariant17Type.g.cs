
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: webhook
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant17Type
    {
        /// <summary>
        /// webhook
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant17Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant17Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => GetObservabilityDestinationResponseDataVariant17Type.Webhook,
                _ => null,
            };
        }
    }
}