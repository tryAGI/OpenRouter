
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Aggregated usage statistics for the request
    /// </summary>
    public sealed partial class STTUsage
    {
        /// <summary>
        /// Total cost of the request in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Number of input tokens billed for this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Number of output tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Duration of the input audio in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public double? Seconds { get; set; }

        /// <summary>
        /// Total number of tokens used (input + output)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTUsage" /> class.
        /// </summary>
        /// <param name="cost">
        /// Total cost of the request in USD
        /// </param>
        /// <param name="inputTokens">
        /// Number of input tokens billed for this request
        /// </param>
        /// <param name="outputTokens">
        /// Number of output tokens generated
        /// </param>
        /// <param name="seconds">
        /// Duration of the input audio in seconds
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used (input + output)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTUsage(
            double? cost,
            int? inputTokens,
            int? outputTokens,
            double? seconds,
            int? totalTokens)
        {
            this.Cost = cost;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Seconds = seconds;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTUsage" /> class.
        /// </summary>
        public STTUsage()
        {
        }
    }
}