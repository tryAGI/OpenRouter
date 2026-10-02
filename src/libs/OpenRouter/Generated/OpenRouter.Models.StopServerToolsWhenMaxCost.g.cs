
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop once cumulative cost across the loop exceeds this dollar threshold.<br/>
    /// Example: {"max_cost_in_dollars":0.5,"type":"max_cost"}
    /// </summary>
    public sealed partial class StopServerToolsWhenMaxCost
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_cost_in_dollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxCostInDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenMaxCostTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenMaxCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenMaxCost" /> class.
        /// </summary>
        /// <param name="maxCostInDollars"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenMaxCost(
            double maxCostInDollars,
            global::OpenRouter.StopServerToolsWhenMaxCostType type)
        {
            this.MaxCostInDollars = maxCostInDollars;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenMaxCost" /> class.
        /// </summary>
        public StopServerToolsWhenMaxCost()
        {
        }

    }
}