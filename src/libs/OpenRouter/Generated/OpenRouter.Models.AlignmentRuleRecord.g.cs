
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlignmentRuleRecord
    {
        /// <summary>
        /// Whether probability is at or above the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Broken { get; set; }

        /// <summary>
        /// The evaluator's probability that the turn breaks the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Probability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentRuleRecord" /> class.
        /// </summary>
        /// <param name="broken">
        /// Whether probability is at or above the threshold.
        /// </param>
        /// <param name="probability">
        /// The evaluator's probability that the turn breaks the rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentRuleRecord(
            bool broken,
            double probability)
        {
            this.Broken = broken;
            this.Probability = probability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentRuleRecord" /> class.
        /// </summary>
        public AlignmentRuleRecord()
        {
        }

    }
}