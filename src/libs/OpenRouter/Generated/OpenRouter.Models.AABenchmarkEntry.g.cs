
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Artificial Analysis benchmark index scores.<br/>
    /// Example: {"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4}
    /// </summary>
    public sealed partial class AABenchmarkEntry
    {
        /// <summary>
        /// Artificial Analysis Agentic Index score<br/>
        /// Example: 55.8F
        /// </summary>
        /// <example>55.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_index")]
        public double? AgenticIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Coding Index score<br/>
        /// Example: 63.2F
        /// </summary>
        /// <example>63.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coding_index")]
        public double? CodingIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Intelligence Index score<br/>
        /// Example: 71.4F
        /// </summary>
        /// <example>71.4F</example>
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
        /// Artificial Analysis Agentic Index score<br/>
        /// Example: 55.8F
        /// </param>
        /// <param name="codingIndex">
        /// Artificial Analysis Coding Index score<br/>
        /// Example: 63.2F
        /// </param>
        /// <param name="intelligenceIndex">
        /// Artificial Analysis Intelligence Index score<br/>
        /// Example: 71.4F
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