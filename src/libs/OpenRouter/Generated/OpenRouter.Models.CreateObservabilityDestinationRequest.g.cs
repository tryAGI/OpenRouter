
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"config":{"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"},"name":"Production Langfuse","type":"langfuse"}
    /// </summary>
    public sealed partial class CreateObservabilityDestinationRequest
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes whose traffic is forwarded. `null` or omitted means all keys. Must contain at least one hash if provided.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// When true, include cost and billing generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_cost")]
        public bool? BroadcastGenerationCost { get; set; }

        /// <summary>
        /// When true, include identity generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_identity")]
        public bool? BroadcastGenerationIdentity { get; set; }

        /// <summary>
        /// When true, include request-context generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_request_context")]
        public bool? BroadcastGenerationRequestContext { get; set; }

        /// <summary>
        /// Provider-specific configuration. The shape depends on `type` and is validated server-side.<br/>
        /// Example: {"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}
        /// </summary>
        /// <example>{"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// Whether this destination should be enabled immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional structured filter rules controlling which events are forwarded.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_rules")]
        public global::OpenRouter.ObservabilityFilterRulesConfigNullable? FilterRules { get; set; }

        /// <summary>
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </summary>
        /// <example>Production Langfuse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_mode")]
        public bool? PrivacyMode { get; set; }

        /// <summary>
        /// Data regions this destination applies to. `eu` is accepted as an alias for `europe` and normalizes to `europe`. Omitting this field defaults to ['global']; the array must be non-empty.<br/>
        /// Default Value: [global]<br/>
        /// Example: [global]
        /// </summary>
        /// <example>[global]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? Regions { get; set; }

        /// <summary>
        /// Sampling rate between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        public double? SamplingRate { get; set; }

        /// <summary>
        /// The destination type. Only stable destination types are accepted.<br/>
        /// Example: langfuse
        /// </summary>
        /// <example>langfuse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateObservabilityDestinationRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreateObservabilityDestinationRequestType Type { get; set; }

        /// <summary>
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
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
        /// Provider-specific configuration. The shape depends on `type` and is validated server-side.<br/>
        /// Example: {"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </param>
        /// <param name="type">
        /// The destination type. Only stable destination types are accepted.<br/>
        /// Example: langfuse
        /// </param>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes whose traffic is forwarded. `null` or omitted means all keys. Must contain at least one hash if provided.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="broadcastGenerationCost">
        /// When true, include cost and billing generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationIdentity">
        /// When true, include identity generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationRequestContext">
        /// When true, include request-context generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="enabled">
        /// Whether this destination should be enabled immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules controlling which events are forwarded.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="regions">
        /// Data regions this destination applies to. `eu` is accepted as an alias for `europe` and normalizes to `europe`. Omitting this field defaults to ['global']; the array must be non-empty.<br/>
        /// Default Value: [global]<br/>
        /// Example: [global]
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObservabilityDestinationRequest(
            object config,
            string name,
            global::OpenRouter.CreateObservabilityDestinationRequestType type,
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            bool? broadcastGenerationCost,
            bool? broadcastGenerationIdentity,
            bool? broadcastGenerationRequestContext,
            bool? enabled,
            global::OpenRouter.ObservabilityFilterRulesConfigNullable? filterRules,
            bool? privacyMode,
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? regions,
            double? samplingRate,
            global::System.Guid? workspaceId)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.BroadcastGenerationCost = broadcastGenerationCost;
            this.BroadcastGenerationIdentity = broadcastGenerationIdentity;
            this.BroadcastGenerationRequestContext = broadcastGenerationRequestContext;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Enabled = enabled;
            this.FilterRules = filterRules;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PrivacyMode = privacyMode;
            this.Regions = regions;
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