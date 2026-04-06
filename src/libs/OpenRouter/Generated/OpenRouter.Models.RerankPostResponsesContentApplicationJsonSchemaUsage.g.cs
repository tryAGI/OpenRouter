
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Usage statistics
    /// </summary>
    public sealed partial class RerankPostResponsesContentApplicationJsonSchemaUsage
    {
        /// <summary>
        /// Total number of tokens used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Number of search units consumed (Cohere billing)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_units")]
        public int? SearchUnits { get; set; }

        /// <summary>
        /// Cost of the request in credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// Total number of tokens used
        /// </param>
        /// <param name="searchUnits">
        /// Number of search units consumed (Cohere billing)
        /// </param>
        /// <param name="cost">
        /// Cost of the request in credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostResponsesContentApplicationJsonSchemaUsage(
            int? totalTokens,
            int? searchUnits,
            double? cost)
        {
            this.TotalTokens = totalTokens;
            this.SearchUnits = searchUnits;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        public RerankPostResponsesContentApplicationJsonSchemaUsage()
        {
        }
    }
}