
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"enabled":true,"id":"pareto-router","max_price":5,"price_source":"prompt"}
    /// </summary>
    public sealed partial class ParetoRouterPlugin
    {
        /// <summary>
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ParetoRouterPluginIdJsonConverter))]
        public global::OpenRouter.ParetoRouterPluginId Id { get; set; }

        /// <summary>
        /// Maximum input price in USD per million tokens. When set, quality-tier selection (min_coding_score) is bypassed: the router computes the Pareto frontier over the top coding models and routes to the best-scoring frontier model priced at or below this cap, falling back through cheaper frontier models, then non-frontier models. Enforced against the price source given by price_source. Returns 404 when no candidate satisfies the cap.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_price")]
        public double? MaxPrice { get; set; }

        /// <summary>
        /// Selects one of three tiers of coding models with a number between 0 and 1. It is not a threshold on a model score: the tiers are groups of the current shortlist of top coding models. &gt;= 0.66 → high (the strongest group), &gt;= 0.33 → medium (the two strongest groups), &lt; 0.33 → low (the whole shortlist). Omit to use the high tier. Not used when max_price is set (price-based selection takes over).<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_coding_score")]
        public double? MinCodingScore { get; set; }

        /// <summary>
        /// Price source for the Pareto frontier cost axis and for enforcing max_price. "prompt" uses catalog list price (endpoint.pricing.prompt). "weighted_avg" uses traffic-weighted effective input price from ClickHouse, falling back to prompt price for models without traffic data. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ParetoRouterPluginPriceSourceJsonConverter))]
        public global::OpenRouter.ParetoRouterPluginPriceSource? PriceSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoRouterPlugin" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="id"></param>
        /// <param name="maxPrice">
        /// Maximum input price in USD per million tokens. When set, quality-tier selection (min_coding_score) is bypassed: the router computes the Pareto frontier over the top coding models and routes to the best-scoring frontier model priced at or below this cap, falling back through cheaper frontier models, then non-frontier models. Enforced against the price source given by price_source. Returns 404 when no candidate satisfies the cap.<br/>
        /// Example: 5
        /// </param>
        /// <param name="minCodingScore">
        /// Selects one of three tiers of coding models with a number between 0 and 1. It is not a threshold on a model score: the tiers are groups of the current shortlist of top coding models. &gt;= 0.66 → high (the strongest group), &gt;= 0.33 → medium (the two strongest groups), &lt; 0.33 → low (the whole shortlist). Omit to use the high tier. Not used when max_price is set (price-based selection takes over).<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="priceSource">
        /// Price source for the Pareto frontier cost axis and for enforcing max_price. "prompt" uses catalog list price (endpoint.pricing.prompt). "weighted_avg" uses traffic-weighted effective input price from ClickHouse, falling back to prompt price for models without traffic data. Defaults to "prompt".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParetoRouterPlugin(
            bool? enabled,
            global::OpenRouter.ParetoRouterPluginId id,
            double? maxPrice,
            double? minCodingScore,
            global::OpenRouter.ParetoRouterPluginPriceSource? priceSource)
        {
            this.Enabled = enabled;
            this.Id = id;
            this.MaxPrice = maxPrice;
            this.MinCodingScore = minCodingScore;
            this.PriceSource = priceSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoRouterPlugin" /> class.
        /// </summary>
        public ParetoRouterPlugin()
        {
        }

    }
}