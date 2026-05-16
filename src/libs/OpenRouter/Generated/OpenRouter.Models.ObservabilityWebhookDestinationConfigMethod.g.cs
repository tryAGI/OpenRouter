
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum ObservabilityWebhookDestinationConfigMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityWebhookDestinationConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityWebhookDestinationConfigMethod value)
        {
            return value switch
            {
                ObservabilityWebhookDestinationConfigMethod.Post => "POST",
                ObservabilityWebhookDestinationConfigMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityWebhookDestinationConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => ObservabilityWebhookDestinationConfigMethod.Post,
                "PUT" => ObservabilityWebhookDestinationConfigMethod.Put,
                _ => null,
            };
        }
    }
}