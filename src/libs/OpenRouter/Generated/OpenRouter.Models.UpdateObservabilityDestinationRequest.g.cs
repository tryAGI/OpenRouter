
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationRequest
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes. `null` clears the filter (all keys). Omitting leaves the current value. Must contain at least one hash if provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// Provider-specific configuration fields to update. Masked values are ignored; unset fields keep their current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Whether the destination is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional structured filter rules. `null` clears the rules. Omitting keeps the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_rules")]
        public global::OpenRouter.UpdateObservabilityDestinationRequestFilterRules? FilterRules { get; set; }

        /// <summary>
        /// Human-readable name for the destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When true, request/response bodies are not forwarded — only metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_mode")]
        public bool? PrivacyMode { get; set; }

        /// <summary>
        /// Sampling rate between 0 and 1 (1 = 100%).
        /// </summary>
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
        /// Optional allowlist of OpenRouter API key hashes. `null` clears the filter (all keys). Omitting leaves the current value. Must contain at least one hash if provided.
        /// </param>
        /// <param name="config">
        /// Provider-specific configuration fields to update. Masked values are ignored; unset fields keep their current value.
        /// </param>
        /// <param name="enabled">
        /// Whether the destination is enabled.
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules. `null` clears the rules. Omitting keeps the current value.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0 and 1 (1 = 100%).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationRequest(
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            object? config,
            bool? enabled,
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRules? filterRules,
            string? name,
            bool? privacyMode,
            double? samplingRate)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.Config = config;
            this.Enabled = enabled;
            this.FilterRules = filterRules;
            this.Name = name;
            this.PrivacyMode = privacyMode;
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