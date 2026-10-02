
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"****...AbCd","projectName":"openrouter-prod","workspace":"my-workspace"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Opik","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"opik","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    public sealed partial class ObservabilityOpikDestination
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) whose traffic is forwarded to this destination. `null` means all keys.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// When true, include cost and billing generation metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BroadcastGenerationCost { get; set; }

        /// <summary>
        /// When true, include identity generation metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BroadcastGenerationIdentity { get; set; }

        /// <summary>
        /// When true, include request-context generation metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_request_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BroadcastGenerationRequestContext { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ObservabilityOpikDestinationConfig Config { get; set; }

        /// <summary>
        /// ISO timestamp of when the destination was created.<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether this destination is currently enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Optional structured filter rules controlling which events are forwarded.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_rules")]
        public global::OpenRouter.ObservabilityFilterRulesConfig? FilterRules { get; set; }

        /// <summary>
        /// Stable public identifier for this destination.<br/>
        /// Example: 99999999-aaaa-bbbb-cccc-dddddddddddd
        /// </summary>
        /// <example>99999999-aaaa-bbbb-cccc-dddddddddddd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </summary>
        /// <example>Production Langfuse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When true, request/response bodies are not forwarded to this destination — only metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PrivacyMode { get; set; }

        /// <summary>
        /// Data regions this destination applies to. Requests served in a region only fan out to destinations that include that region.<br/>
        /// Example: [global]
        /// </summary>
        /// <example>[global]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegion> Regions { get; set; }

        /// <summary>
        /// Sampling rate for events sent to this destination, between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ObservabilityOpikDestinationTypeJsonConverter))]
        public global::OpenRouter.ObservabilityOpikDestinationType Type { get; set; }

        /// <summary>
        /// ISO timestamp of when the destination was last updated.<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </summary>
        /// <example>2025-08-24T15:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// ID of the workspace this destination belongs to.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityOpikDestination" /> class.
        /// </summary>
        /// <param name="broadcastGenerationCost">
        /// When true, include cost and billing generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationIdentity">
        /// When true, include identity generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationRequestContext">
        /// When true, include request-context generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="config"></param>
        /// <param name="createdAt">
        /// ISO timestamp of when the destination was created.<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="enabled">
        /// Whether this destination is currently enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="id">
        /// Stable public identifier for this destination.<br/>
        /// Example: 99999999-aaaa-bbbb-cccc-dddddddddddd
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded to this destination — only metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="regions">
        /// Data regions this destination applies to. Requests served in a region only fan out to destinations that include that region.<br/>
        /// Example: [global]
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate for events sent to this destination, between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </param>
        /// <param name="updatedAt">
        /// ISO timestamp of when the destination was last updated.<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this destination belongs to.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) whose traffic is forwarded to this destination. `null` means all keys.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules controlling which events are forwarded.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityOpikDestination(
            bool broadcastGenerationCost,
            bool broadcastGenerationIdentity,
            bool broadcastGenerationRequestContext,
            global::OpenRouter.ObservabilityOpikDestinationConfig config,
            string createdAt,
            bool enabled,
            global::System.Guid id,
            bool privacyMode,
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegion> regions,
            double samplingRate,
            string updatedAt,
            global::System.Guid workspaceId,
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            global::OpenRouter.ObservabilityFilterRulesConfig? filterRules,
            string? name,
            global::OpenRouter.ObservabilityOpikDestinationType type)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.BroadcastGenerationCost = broadcastGenerationCost;
            this.BroadcastGenerationIdentity = broadcastGenerationIdentity;
            this.BroadcastGenerationRequestContext = broadcastGenerationRequestContext;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Enabled = enabled;
            this.FilterRules = filterRules;
            this.Id = id;
            this.Name = name;
            this.PrivacyMode = privacyMode;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
            this.SamplingRate = samplingRate;
            this.Type = type;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityOpikDestination" /> class.
        /// </summary>
        public ObservabilityOpikDestination()
        {
        }

    }
}