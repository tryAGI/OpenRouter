
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
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
        /// Initializes a new instance of the <see cref="ParetoRouterPlugin" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set to false to disable the pareto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="id"></param>
        /// <param name="minCodingScore">
        /// Minimum desired coding score between 0 and 1, where 1 is best. Higher values select from stronger coding models (sourced from Artificial Analysis coding percentiles). Maps internally to one of three tiers (low, medium, high). Omit to use the router default tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParetoRouterPlugin(
            bool? enabled,
            global::OpenRouter.ParetoRouterPluginId id,
            double? minCodingScore)
        {
            this.Enabled = enabled;
            this.Id = id;
            this.MinCodingScore = minCodingScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoRouterPlugin" /> class.
        /// </summary>
        public ParetoRouterPlugin()
        {
        }
    }
}