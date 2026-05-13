
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// pareto-router variant
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItemsVariant6
    {
        /// <summary>
        /// Discriminator value: pareto-router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant6IdJsonConverter))]
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Minimum desired coding score between 0 and 1, where 1 is best. Higher values select from stronger coding models (sourced from Artificial Analysis coding percentiles). Maps internally to one of three tiers (low, medium, high). Omit to use the router default tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_coding_score")]
        public double? MinCodingScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant6" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: pareto-router
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="minCodingScore">
        /// Minimum desired coding score between 0 and 1, where 1 is best. Higher values select from stronger coding models (sourced from Artificial Analysis coding percentiles). Maps internally to one of three tiers (low, medium, high). Omit to use the router default tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestPluginsItemsVariant6(
            global::OpenRouter.ResponsesRequestPluginsItemsVariant6Id id,
            bool? enabled,
            double? minCodingScore)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.MinCodingScore = minCodingScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant6" /> class.
        /// </summary>
        public ResponsesRequestPluginsItemsVariant6()
        {
        }

    }
}