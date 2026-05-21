
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: webhook
    /// </summary>
    public enum ObservabilityDestinationVariant17Type
    {
        /// <summary>
        /// webhook
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant17Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant17Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ObservabilityDestinationVariant17Type.Webhook,
                _ => null,
            };
        }
    }
}