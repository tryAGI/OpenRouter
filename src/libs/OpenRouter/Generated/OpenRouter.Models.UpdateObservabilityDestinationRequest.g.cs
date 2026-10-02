
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"enabled":false,"name":"Updated Langfuse"}
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationRequest
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes. `null` clears the filter (all keys). Omitting leaves the current value. Must contain at least one hash if provided.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// Whether to include cost and billing generation metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_cost")]
        public bool? BroadcastGenerationCost { get; set; }

        /// <summary>
        /// Whether to include identity generation metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_identity")]
        public bool? BroadcastGenerationIdentity { get; set; }

        /// <summary>
        /// Whether to include request-context generation metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_generation_request_context")]
        public bool? BroadcastGenerationRequestContext { get; set; }

        /// <summary>
        /// Provider-specific configuration fields to update. Masked values are ignored; unset fields keep their current value.<br/>
        /// Example: {"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}
        /// </summary>
        /// <example>{"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Whether the destination is enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_rules")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>? FilterRules { get; set; }

        /// <summary>
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </summary>
        /// <example>Production Langfuse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_mode")]
        public bool? PrivacyMode { get; set; }

        /// <summary>
        /// Data regions this destination applies to. `eu` is accepted as an alias for `europe` and normalizes to `europe`. Omitting this field keeps the current value; it cannot be cleared.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequest" /> class.
        /// </summary>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes. `null` clears the filter (all keys). Omitting leaves the current value. Must contain at least one hash if provided.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="broadcastGenerationCost">
        /// Whether to include cost and billing generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationIdentity">
        /// Whether to include identity generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationRequestContext">
        /// Whether to include request-context generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="config">
        /// Provider-specific configuration fields to update. Masked values are ignored; unset fields keep their current value.<br/>
        /// Example: {"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}
        /// </param>
        /// <param name="enabled">
        /// Whether the destination is enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="filterRules"></param>
        /// <param name="name">
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="regions">
        /// Data regions this destination applies to. `eu` is accepted as an alias for `europe` and normalizes to `europe`. Omitting this field keeps the current value; it cannot be cleared.<br/>
        /// Example: [global]
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationRequest(
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            bool? broadcastGenerationCost,
            bool? broadcastGenerationIdentity,
            bool? broadcastGenerationRequestContext,
            object? config,
            bool? enabled,
            global::OpenRouter.AllOf<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>? filterRules,
            string? name,
            bool? privacyMode,
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? regions,
            double? samplingRate)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.BroadcastGenerationCost = broadcastGenerationCost;
            this.BroadcastGenerationIdentity = broadcastGenerationIdentity;
            this.BroadcastGenerationRequestContext = broadcastGenerationRequestContext;
            this.Config = config;
            this.Enabled = enabled;
            this.FilterRules = filterRules;
            this.Name = name;
            this.PrivacyMode = privacyMode;
            this.Regions = regions;
            this.SamplingRate = samplingRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequest" /> class.
        /// </summary>
        public UpdateObservabilityDestinationRequest()
        {
        }

    }
}