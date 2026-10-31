
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionsUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Number of upstream passes when the fields did not fit in one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passes")]
        public int? Passes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_tokens")]
        public int? SchemaTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_tokens")]
        public int? StateTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionsUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cost"></param>
        /// <param name="imageTokens"></param>
        /// <param name="passes">
        /// Number of upstream passes when the fields did not fit in one.
        /// </param>
        /// <param name="schemaTokens"></param>
        /// <param name="stateTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionsUsage(
            int inputTokens,
            int outputTokens,
            double? cost,
            int? imageTokens,
            int? passes,
            int? schemaTokens,
            int? stateTokens)
        {
            this.Cost = cost;
            this.ImageTokens = imageTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Passes = passes;
            this.SchemaTokens = schemaTokens;
            this.StateTokens = stateTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionsUsage" /> class.
        /// </summary>
        public ExtractionsUsage()
        {
        }

    }
}