
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: webhook
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant17Type
    {
        /// <summary>
        /// webhook
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant17Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant17Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateObservabilityDestinationResponseDataVariant17Type.Webhook,
                _ => null,
            };
        }
    }
}