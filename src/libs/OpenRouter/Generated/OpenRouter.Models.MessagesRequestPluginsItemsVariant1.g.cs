
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// auto-router variant
    /// </summary>
    public sealed partial class MessagesRequestPluginsItemsVariant1
    {
        /// <summary>
        /// Discriminator value: auto-router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant1IdJsonConverter))]
        public global::OpenRouter.MessagesRequestPluginsItemsVariant1Id Id { get; set; }

        /// <summary>
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Controls cost vs. quality routing tradeoff (0–10). 0 = pure quality (best model regardless of cost), 10 = maximize for cost (cheapest model wins). Intermediate values blend quality and cost signals continuously. Defaults to 7.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_quality_tradeoff")]
        public int? CostQualityTradeoff { get; set; }

        /// <summary>
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: auto-router
        /// </param>
        /// <param name="allowedModels">
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </param>
        /// <param name="costQualityTradeoff">
        /// Controls cost vs. quality routing tradeoff (0–10). 0 = pure quality (best model regardless of cost), 10 = maximize for cost (cheapest model wins). Intermediate values blend quality and cost signals continuously. Defaults to 7.
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestPluginsItemsVariant1(
            global::OpenRouter.MessagesRequestPluginsItemsVariant1Id id,
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
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant1" /> class.
        /// </summary>
        public MessagesRequestPluginsItemsVariant1()
        {
        }

    }
}