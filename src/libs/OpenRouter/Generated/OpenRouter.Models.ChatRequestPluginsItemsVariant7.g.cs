
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// pareto-router variant
    /// </summary>
    public sealed partial class ChatRequestPluginsItemsVariant7
    {
        /// <summary>
        /// Discriminator value: pareto-router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant7IdJsonConverter))]
        public global::OpenRouter.ChatRequestPluginsItemsVariant7Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Minimum coding quality score between 0 and 1. Maps to internal quality tiers: &gt;= 0.66 → high (top coding models), &gt;= 0.33 → medium (strong modern flagships), &lt; 0.33 → low (capable coders above the median). Omit to default to the highest tier (equivalent to &gt;= 0.66).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_coding_score")]
        public double? MinCodingScore { get; set; }

        /// <summary>
        /// Price source for the Pareto frontier cost axis. "prompt" uses catalog list price (endpoint.pricing.prompt). "weighted_avg" uses traffic-weighted effective input price from ClickHouse, falling back to prompt price for models without traffic data. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSourceJsonConverter))]
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource? PriceSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant7" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: pareto-router
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="minCodingScore">
        /// Minimum coding quality score between 0 and 1. Maps to internal quality tiers: &gt;= 0.66 → high (top coding models), &gt;= 0.33 → medium (strong modern flagships), &lt; 0.33 → low (capable coders above the median). Omit to default to the highest tier (equivalent to &gt;= 0.66).
        /// </param>
        /// <param name="priceSource">
        /// Price source for the Pareto frontier cost axis. "prompt" uses catalog list price (endpoint.pricing.prompt). "weighted_avg" uses traffic-weighted effective input price from ClickHouse, falling back to prompt price for models without traffic data. Defaults to "prompt".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestPluginsItemsVariant7(
            global::OpenRouter.ChatRequestPluginsItemsVariant7Id id,
            bool? enabled,
            double? minCodingScore,
            global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource? priceSource)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.MinCodingScore = minCodingScore;
            this.PriceSource = priceSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant7" /> class.
        /// </summary>
        public ChatRequestPluginsItemsVariant7()
        {
        }

    }
}