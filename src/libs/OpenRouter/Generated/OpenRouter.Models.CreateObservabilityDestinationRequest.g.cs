
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateObservabilityDestinationRequest
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes whose traffic is forwarded. `null` or omitted means all keys. Must contain at least one hash if provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// Provider-specific configuration. The shape depends on `type` and is validated server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// Whether this destination should be enabled immediately.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional structured filter rules controlling which events are forwarded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_rules")]
        public global::OpenRouter.ObservabilityFilterRulesConfig? FilterRules { get; set; }

        /// <summary>
        /// Human-readable name for the destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_mode")]
        public bool? PrivacyMode { get; set; }

        /// <summary>
        /// Sampling rate between 0 and 1 (1 = 100%).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        public double? SamplingRate { get; set; }

        /// <summary>
        /// The destination type. Only stable destination types are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateObservabilityDestinationRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreateObservabilityDestinationRequestType Type { get; set; }

        /// <summary>
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservabilityDestinationRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Provider-specific configuration. The shape depends on `type` and is validated server-side.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.
        /// </param>
        /// <param name="type">
        /// The destination type. Only stable destination types are accepted.
        /// </param>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes whose traffic is forwarded. `null` or omitted means all keys. Must contain at least one hash if provided.
        /// </param>
        /// <param name="enabled">
        /// Whether this destination should be enabled immediately.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules controlling which events are forwarded.
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0 and 1 (1 = 100%).
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObservabilityDestinationRequest(
            object config,
            string name,
            global::OpenRouter.CreateObservabilityDestinationRequestType type,
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            bool? enabled,
            global::OpenRouter.ObservabilityFilterRulesConfig? filterRules,
            bool? privacyMode,
            double? samplingRate,
            global::System.Guid? workspaceId)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Enabled = enabled;
            this.FilterRules = filterRules;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PrivacyMode = privacyMode;
            this.SamplingRate = samplingRate;
            this.Type = type;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservabilityDestinationRequest" /> class.
        /// </summary>
        public CreateObservabilityDestinationRequest()
        {
        }

    }
}