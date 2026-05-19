
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop once cumulative cost across the loop exceeds this dollar threshold.
    /// </summary>
    public sealed partial class StopServerToolsWhenConditionVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenMaxCostTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenMaxCostType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_cost_in_dollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxCostInDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenConditionVariant3" /> class.
        /// </summary>
        /// <param name="maxCostInDollars"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenConditionVariant3(
            double maxCostInDollars,
            global::OpenRouter.StopServerToolsWhenMaxCostType type)
        {
            this.Type = type;
            this.MaxCostInDollars = maxCostInDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenConditionVariant3" /> class.
        /// </summary>
        public StopServerToolsWhenConditionVariant3()
        {
        }

    }
}