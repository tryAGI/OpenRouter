
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FusionAnalysisResultContradictionsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionsItemsStancesItems> Stances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Topic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultContradictionsItems" /> class.
        /// </summary>
        /// <param name="stances"></param>
        /// <param name="topic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionAnalysisResultContradictionsItems(
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionsItemsStancesItems> stances,
            string topic)
        {
            this.Stances = stances ?? throw new global::System.ArgumentNullException(nameof(stances));
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultContradictionsItems" /> class.
        /// </summary>
        public FusionAnalysisResultContradictionsItems()
        {
        }

    }
}