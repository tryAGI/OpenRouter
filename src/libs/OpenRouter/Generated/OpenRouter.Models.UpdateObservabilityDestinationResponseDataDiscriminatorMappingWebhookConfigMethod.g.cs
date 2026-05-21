
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: POST
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod
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
    public static class UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod.Post => "POST",
                UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod.Post,
                "PUT" => UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod.Put,
                _ => null,
            };
        }
    }
}