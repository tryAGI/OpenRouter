
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Artificial Analysis benchmark index scores.
    /// </summary>
    public sealed partial class AABenchmarkEntry
    {
        /// <summary>
        /// Artificial Analysis Agentic Index score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_index")]
        public double? AgenticIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Coding Index score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coding_index")]
        public double? CodingIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Intelligence Index score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence_index")]
        public double? IntelligenceIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AABenchmarkEntry" /> class.
        /// </summary>
        /// <param name="agenticIndex">
        /// Artificial Analysis Agentic Index score
        /// </param>
        /// <param name="codingIndex">
        /// Artificial Analysis Coding Index score
        /// </param>
        /// <param name="intelligenceIndex">
        /// Artificial Analysis Intelligence Index score
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AABenchmarkEntry(
            double? agenticIndex,
            double? codingIndex,
            double? intelligenceIndex)
        {
            this.AgenticIndex = agenticIndex;
            this.CodingIndex = codingIndex;
            this.IntelligenceIndex = intelligenceIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AABenchmarkEntry" /> class.
        /// </summary>
        public AABenchmarkEntry()
        {
        }

    }
}