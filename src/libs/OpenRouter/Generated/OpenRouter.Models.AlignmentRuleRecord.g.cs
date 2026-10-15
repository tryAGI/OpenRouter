
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlignmentRuleRecord
    {
        /// <summary>
        /// Whether the message has a field the rule watches. Only an applicable rule is evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Applicable { get; set; }

        /// <summary>
        /// Whether probability is at or above the threshold. False when the rule is not applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Broken { get; set; }

        /// <summary>
        /// The evaluator's probability that the turn breaks the rule; null when the rule is not applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        public double? Probability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentRuleRecord" /> class.
        /// </summary>
        /// <param name="applicable">
        /// Whether the message has a field the rule watches. Only an applicable rule is evaluated.
        /// </param>
        /// <param name="broken">
        /// Whether probability is at or above the threshold. False when the rule is not applicable.
        /// </param>
        /// <param name="probability">
        /// The evaluator's probability that the turn breaks the rule; null when the rule is not applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentRuleRecord(
            bool applicable,
            bool broken,
            double? probability)
        {
            this.Applicable = applicable;
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