
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Default Value: https://api.smith.langchain.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The name for this project, such as pr-openrouter-demo. Defaults to "main" if not set.<br/>
        /// Default Value: main
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Required for org-scoped API keys. Find this in your LangSmith workspace settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceId")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="endpoint">
        /// Default Value: https://api.smith.langchain.com
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
        /// <param name="project">
        /// The name for this project, such as pr-openrouter-demo. Defaults to "main" if not set.<br/>
        /// Default Value: main
        /// </param>
        /// <param name="workspaceId">
        /// Required for org-scoped API keys. Find this in your LangSmith workspace settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig(
            string apiKey,
            string? endpoint,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? project,
            string? workspaceId)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Endpoint = endpoint;
            this.Headers = headers;
            this.Project = project;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig()
        {
        }

    }
}