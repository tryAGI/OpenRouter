
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGuardrailRequest
    {
        /// <summary>
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// New list of allowed provider IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        /// New description for the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        /// Array of model identifiers to exclude from routing (slug or canonical_slug accepted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_models")]
        public global::System.Collections.Generic.IList<string>? IgnoredModels { get; set; }

        /// <summary>
        /// List of provider IDs to exclude from routing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_providers")]
        public global::System.Collections.Generic.IList<string>? IgnoredProviders { get; set; }

        /// <summary>
        /// New spending limit in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// New name for the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter))]
        public global::OpenRouter.GuardrailInterval? ResetInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="allowedProviders">
        /// New list of allowed provider IDs
        /// </param>
        /// <param name="description">
        /// New description for the guardrail
        /// </param>
        /// <param name="enforceZdr">
        /// Whether to enforce zero data retention
        /// </param>
        /// <param name="ignoredModels">
        /// Array of model identifiers to exclude from routing (slug or canonical_slug accepted)
        /// </param>
        /// <param name="ignoredProviders">
        /// List of provider IDs to exclude from routing
        /// </param>
        /// <param name="limitUsd">
        /// New spending limit in USD
        /// </param>
        /// <param name="name">
        /// New name for the guardrail
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGuardrailRequest(
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            string? description,
            bool? enforceZdr,
            global::System.Collections.Generic.IList<string>? ignoredModels,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            double? limitUsd,
            string? name,
            global::OpenRouter.GuardrailInterval? resetInterval)
        {
            this.AllowedModels = allowedModels;
            this.AllowedProviders = allowedProviders;
            this.Description = description;
            this.EnforceZdr = enforceZdr;
            this.IgnoredModels = ignoredModels;
            this.IgnoredProviders = ignoredProviders;
            this.LimitUsd = limitUsd;
            this.Name = name;
            this.ResetInterval = resetInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        public UpdateGuardrailRequest()
        {
        }
    }
}