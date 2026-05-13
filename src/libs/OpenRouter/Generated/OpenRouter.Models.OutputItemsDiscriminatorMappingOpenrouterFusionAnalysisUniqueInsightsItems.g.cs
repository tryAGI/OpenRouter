
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemsDiscriminatorMappingOpenrouterFusionAnalysisUniqueInsightsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Insight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsDiscriminatorMappingOpenrouterFusionAnalysisUniqueInsightsItems" /> class.
        /// </summary>
        /// <param name="insight"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsDiscriminatorMappingOpenrouterFusionAnalysisUniqueInsightsItems(
            string insight,
            string model)
        {
            this.Insight = insight ?? throw new global::System.ArgumentNullException(nameof(insight));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsDiscriminatorMappingOpenrouterFusionAnalysisUniqueInsightsItems" /> class.
        /// </summary>
        public OutputItemsDiscriminatorMappingOpenrouterFusionAnalysisUniqueInsightsItems()
        {
        }

    }
}