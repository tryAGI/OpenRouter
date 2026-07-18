
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// auto-beta-router variant
    /// </summary>
    public sealed partial class ChatRequestPluginsItemsVariant1
    {
        /// <summary>
        /// Discriminator value: auto-beta-router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant1IdJsonConverter))]
        public global::OpenRouter.ChatRequestPluginsItemsVariant1Id Id { get; set; }

        /// <summary>
        /// List of model patterns to filter which models the auto-beta-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Balances routing between cost and quality on a 0-10 scale. The auto-beta-router ranks models for the classified task type by community spend share, then filters candidates by their average cost per generation for that task. Higher values favor cheaper models: 10 keeps only models around the cheapest 10th percentile, while 0 permits models up to the 90th percentile for cost. Defaults to 7.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_quality_tradeoff")]
        public int? CostQualityTradeoff { get; set; }

        /// <summary>
        /// Set to false to disable the auto-beta-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: auto-beta-router
        /// </param>
        /// <param name="allowedModels">
        /// List of model patterns to filter which models the auto-beta-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </param>
        /// <param name="costQualityTradeoff">
        /// Balances routing between cost and quality on a 0-10 scale. The auto-beta-router ranks models for the classified task type by community spend share, then filters candidates by their average cost per generation for that task. Higher values favor cheaper models: 10 keeps only models around the cheapest 10th percentile, while 0 permits models up to the 90th percentile for cost. Defaults to 7.
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the auto-beta-router plugin for this request. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestPluginsItemsVariant1(
            global::OpenRouter.ChatRequestPluginsItemsVariant1Id id,
            global::System.Collections.Generic.IList<string>? allowedModels,
            int? costQualityTradeoff,
            bool? enabled)
        {
            this.Id = id;
            this.AllowedModels = allowedModels;
            this.CostQualityTradeoff = costQualityTradeoff;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant1" /> class.
        /// </summary>
        public ChatRequestPluginsItemsVariant1()
        {
        }

    }
}