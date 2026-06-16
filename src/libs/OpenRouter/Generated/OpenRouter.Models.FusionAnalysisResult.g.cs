
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Structured analysis produced by the fusion judge model.
    /// </summary>
    public sealed partial class FusionAnalysisResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blind_spots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BlindSpots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Consensus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contradictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionsItems> Contradictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_coverage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItems> PartialCoverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_insights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsightsItems> UniqueInsights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResult" /> class.
        /// </summary>
        /// <param name="blindSpots"></param>
        /// <param name="consensus"></param>
        /// <param name="contradictions"></param>
        /// <param name="partialCoverage"></param>
        /// <param name="uniqueInsights"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionAnalysisResult(
            global::System.Collections.Generic.IList<string> blindSpots,
            global::System.Collections.Generic.IList<string> consensus,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionsItems> contradictions,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItems> partialCoverage,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsightsItems> uniqueInsights)
        {
            this.BlindSpots = blindSpots ?? throw new global::System.ArgumentNullException(nameof(blindSpots));
            this.Consensus = consensus ?? throw new global::System.ArgumentNullException(nameof(consensus));
            this.Contradictions = contradictions ?? throw new global::System.ArgumentNullException(nameof(contradictions));
            this.PartialCoverage = partialCoverage ?? throw new global::System.ArgumentNullException(nameof(partialCoverage));
            this.UniqueInsights = uniqueInsights ?? throw new global::System.ArgumentNullException(nameof(uniqueInsights));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResult" /> class.
        /// </summary>
        public FusionAnalysisResult()
        {
        }

    }
}