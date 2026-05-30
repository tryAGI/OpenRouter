
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// newrelic variant
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataVariant8
    {
        /// <summary>
        /// Discriminator value: newrelic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataVariant8TypeJsonConverter))]
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type Type { get; set; }

        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) whose traffic is forwarded to this destination. `null` means all keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfig Config { get; set; }

        /// <summary>
        /// ISO timestamp of when the destination was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether this destination is currently enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Optional structured filter rules controlling which events are forwarded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ObservabilityFilterRulesConfig FilterRules { get; set; }

        /// <summary>
        /// Stable public identifier for this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Human-readable name for the destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When true, request/response bodies are not forwarded to this destination — only metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PrivacyMode { get; set; }

        /// <summary>
        /// Sampling rate for events sent to this destination, between 0.0001 and 1 (1 = 100%).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        /// ISO timestamp of when the destination was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// ID of the workspace this destination belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataVariant8" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="createdAt">
        /// ISO timestamp of when the destination was created.
        /// </param>
        /// <param name="enabled">
        /// Whether this destination is currently enabled.
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules controlling which events are forwarded.
        /// </param>
        /// <param name="id">
        /// Stable public identifier for this destination.
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded to this destination — only metadata.
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate for events sent to this destination, between 0.0001 and 1 (1 = 100%).
        /// </param>
        /// <param name="updatedAt">
        /// ISO timestamp of when the destination was last updated.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this destination belongs to.
        /// </param>
        /// <param name="type">
        /// Discriminator value: newrelic
        /// </param>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) whose traffic is forwarded to this destination. `null` means all keys.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataVariant8(
            global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfig config,
            string createdAt,
            bool enabled,
            global::OpenRouter.ObservabilityFilterRulesConfig filterRules,
            global::System.Guid id,
            bool privacyMode,
            double samplingRate,
            string updatedAt,
            global::System.Guid workspaceId,
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type type,
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            string? name)
        {
            this.Type = type;
            this.ApiKeyHashes = apiKeyHashes;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Enabled = enabled;
            this.FilterRules = filterRules ?? throw new global::System.ArgumentNullException(nameof(filterRules));
            this.Id = id;
            this.Name = name;
            this.PrivacyMode = privacyMode;
            this.SamplingRate = samplingRate;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataVariant8" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataVariant8()
        {
        }

    }
}