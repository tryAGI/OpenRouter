
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityWebhookDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityWebhookDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityWebhookDestinationType value)
        {
            return value switch
            {
                ObservabilityWebhookDestinationType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityWebhookDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ObservabilityWebhookDestinationType.Webhook,
                _ => null,
            };
        }
    }
}