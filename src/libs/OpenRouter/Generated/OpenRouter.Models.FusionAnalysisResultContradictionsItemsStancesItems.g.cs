
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FusionAnalysisResultContradictionsItemsStancesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultContradictionsItemsStancesItems" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="stance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionAnalysisResultContradictionsItemsStancesItems(
            string model,
            string stance)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Stance = stance ?? throw new global::System.ArgumentNullException(nameof(stance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultContradictionsItemsStancesItems" /> class.
        /// </summary>
        public FusionAnalysisResultContradictionsItemsStancesItems()
        {
        }

    }
}