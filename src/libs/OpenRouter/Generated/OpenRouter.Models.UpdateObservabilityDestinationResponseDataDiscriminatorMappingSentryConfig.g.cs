
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dsn { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otlpEndpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OtlpEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig" /> class.
        /// </summary>
        /// <param name="dsn"></param>
        /// <param name="otlpEndpoint"></param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig(
            string dsn,
            string otlpEndpoint,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Dsn = dsn ?? throw new global::System.ArgumentNullException(nameof(dsn));
            this.Headers = headers;
            this.OtlpEndpoint = otlpEndpoint ?? throw new global::System.ArgumentNullException(nameof(otlpEndpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig()
        {
        }

    }
}