
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter pricing per token for this model. Null if pricing is unavailable.
    /// </summary>
    public sealed partial class UnifiedBenchmarkPricing
    {
        /// <summary>
        /// Cost per output token (USD, decimal string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// Cost per input token (USD, decimal string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarkPricing" /> class.
        /// </summary>
        /// <param name="completion">
        /// Cost per output token (USD, decimal string).
        /// </param>
        /// <param name="prompt">
        /// Cost per input token (USD, decimal string).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarkPricing(
            string completion,
            string prompt)
        {
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarkPricing" /> class.
        /// </summary>
        public UnifiedBenchmarkPricing()
        {
        }

    }
}