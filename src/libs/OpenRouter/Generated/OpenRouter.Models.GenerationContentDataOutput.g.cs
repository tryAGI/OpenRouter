
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output from the generation
    /// </summary>
    public sealed partial class GenerationContentDataOutput
    {
        /// <summary>
        /// The completion output<br/>
        /// Example: The meaning of life is a philosophical question...
        /// </summary>
        /// <example>The meaning of life is a philosophical question...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public string? Completion { get; set; }

        /// <summary>
        /// Reasoning/thinking output, if any<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentDataOutput" /> class.
        /// </summary>
        /// <param name="completion">
        /// The completion output<br/>
        /// Example: The meaning of life is a philosophical question...
        /// </param>
        /// <param name="reasoning">
        /// Reasoning/thinking output, if any<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentDataOutput(
            string? completion,
            string? reasoning)
        {
            this.Completion = completion;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentDataOutput" /> class.
        /// </summary>
        public GenerationContentDataOutput()
        {
        }

    }
}