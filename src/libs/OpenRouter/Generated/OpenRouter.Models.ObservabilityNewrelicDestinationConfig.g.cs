
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilityNewrelicDestinationConfig
    {
        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("licenseKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LicenseKey { get; set; }

        /// <summary>
        /// Default Value: us
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ObservabilityNewrelicDestinationConfigRegionJsonConverter))]
        public global::OpenRouter.ObservabilityNewrelicDestinationConfigRegion? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityNewrelicDestinationConfig" /> class.
        /// </summary>
        /// <param name="licenseKey"></param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
        /// <param name="region">
        /// Default Value: us
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityNewrelicDestinationConfig(
            string licenseKey,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::OpenRouter.ObservabilityNewrelicDestinationConfigRegion? region)
        {
            this.Headers = headers;
            this.LicenseKey = licenseKey ?? throw new global::System.ArgumentNullException(nameof(licenseKey));
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityNewrelicDestinationConfig" /> class.
        /// </summary>
        public ObservabilityNewrelicDestinationConfig()
        {
        }

    }
}