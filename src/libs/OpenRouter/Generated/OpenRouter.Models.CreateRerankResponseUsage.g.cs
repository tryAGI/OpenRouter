
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Usage statistics<br/>
    /// Example: {"search_units":1,"total_tokens":150}
    /// </summary>
    public sealed partial class CreateRerankResponseUsage
    {
        /// <summary>
        /// Cost of the request in credits<br/>
        /// Example: 0.001F
        /// </summary>
        /// <example>0.001F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Number of search units consumed (Cohere billing)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_units")]
        public int? SearchUnits { get; set; }

        /// <summary>
        /// Total number of tokens used<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponseUsage" /> class.
        /// </summary>
        /// <param name="cost">
        /// Cost of the request in credits<br/>
        /// Example: 0.001F
        /// </param>
        /// <param name="searchUnits">
        /// Number of search units consumed (Cohere billing)<br/>
        /// Example: 1
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used<br/>
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankResponseUsage(
            double? cost,
            int? searchUnits,
            int? totalTokens)
        {
            this.Cost = cost;
            this.SearchUnits = searchUnits;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponseUsage" /> class.
        /// </summary>
        public CreateRerankResponseUsage()
        {
        }

    }
}