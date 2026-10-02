
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Structured analysis produced by the fusion analyst model.<br/>
    /// Example: {"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}
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
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradiction> Contradictions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_coverage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItem> PartialCoverage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_insights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsight> UniqueInsights { get; set; }

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
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradiction> contradictions,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItem> partialCoverage,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsight> uniqueInsights)
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