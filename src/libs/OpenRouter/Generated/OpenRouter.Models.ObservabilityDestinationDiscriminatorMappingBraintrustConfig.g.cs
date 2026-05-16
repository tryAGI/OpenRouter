
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilityDestinationDiscriminatorMappingBraintrustConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Default Value: https://api.braintrust.dev
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityDestinationDiscriminatorMappingBraintrustConfig" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="projectId"></param>
        /// <param name="baseUrl">
        /// Default Value: https://api.braintrust.dev
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityDestinationDiscriminatorMappingBraintrustConfig(
            string apiKey,
            string projectId,
            string? baseUrl,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.BaseUrl = baseUrl;
            this.Headers = headers;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityDestinationDiscriminatorMappingBraintrustConfig" /> class.
        /// </summary>
        public ObservabilityDestinationDiscriminatorMappingBraintrustConfig()
        {
        }

    }
}