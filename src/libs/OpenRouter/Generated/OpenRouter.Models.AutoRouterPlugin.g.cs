
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allowed_models":["anthropic/*","openai/*"],"cost_tier":"low","enabled":true,"excluded_models":["openai/gpt-4o"],"id":"auto-router","pin_model":false}
    /// </summary>
    public sealed partial class AutoRouterPlugin
    {
        /// <summary>
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. When not specified, every model ranked for the classified task type is a candidate, falling back to a default model set when rankings are unavailable.<br/>
        /// Example: [anthropic/*, openai/gpt-4o, google/*]
        /// </summary>
        /// <example>[anthropic/*, openai/gpt-4o, google/*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Deprecated: Use cost_tier instead. Balances routing between cost and quality on a 0-10 scale. The auto-router ranks models for the classified task type by community spend share, then filters candidates by their average cost per generation for that task. Higher values favor cheaper models: 10 keeps only models around the cheapest 10th percentile, while 0 permits models up to the 90th percentile for cost. Defaults to 9 when no cost setting is provided. It remains supported and retains ceiling behavior, but cost_tier takes precedence when both are provided.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_quality_tradeoff")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? CostQualityTradeoff { get; set; }

        /// <summary>
        /// Named cost/quality setting. Tiers select cost-percentile bands: low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.<br/>
        /// Example: low
        /// </summary>
        /// <example>low</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AutoRouterPluginCostTierJsonConverter))]
        public global::OpenRouter.AutoRouterPluginCostTier? CostTier { get; set; }

        /// <summary>
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// List of model patterns to exclude from auto-router selection. Supports wildcards (e.g., "meta-llama/*" excludes all Llama models). Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. Applied after allowed_models, so an excluded pattern always wins over an allowed one.<br/>
        /// Example: [openai/gpt-4o, meta-llama/*]
        /// </summary>
        /// <example>[openai/gpt-4o, meta-llama/*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_models")]
        public global::System.Collections.Generic.IList<string>? ExcludedModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AutoRouterPluginIdJsonConverter))]
        public global::OpenRouter.AutoRouterPluginId Id { get; set; }

        /// <summary>
        /// When true, reuses the model from the most recent assistant message's `model` attribute for subsequent turns. Defaults to false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pin_model")]
        public bool? PinModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPlugin" /> class.
        /// </summary>
        /// <param name="allowedModels">
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. When not specified, every model ranked for the classified task type is a candidate, falling back to a default model set when rankings are unavailable.<br/>
        /// Example: [anthropic/*, openai/gpt-4o, google/*]
        /// </param>
        /// <param name="costTier">
        /// Named cost/quality setting. Tiers select cost-percentile bands: low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.<br/>
        /// Example: low
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="excludedModels">
        /// List of model patterns to exclude from auto-router selection. Supports wildcards (e.g., "meta-llama/*" excludes all Llama models). Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. Applied after allowed_models, so an excluded pattern always wins over an allowed one.<br/>
        /// Example: [openai/gpt-4o, meta-llama/*]
        /// </param>
        /// <param name="id"></param>
        /// <param name="pinModel">
        /// When true, reuses the model from the most recent assistant message's `model` attribute for subsequent turns. Defaults to false.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterPlugin(
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::OpenRouter.AutoRouterPluginCostTier? costTier,
            bool? enabled,
            global::System.Collections.Generic.IList<string>? excludedModels,
            global::OpenRouter.AutoRouterPluginId id,
            bool? pinModel)
        {
            this.AllowedModels = allowedModels;
            this.CostTier = costTier;
            this.Enabled = enabled;
            this.ExcludedModels = excludedModels;
            this.Id = id;
            this.PinModel = pinModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPlugin" /> class.
        /// </summary>
        public AutoRouterPlugin()
        {
        }

    }
}