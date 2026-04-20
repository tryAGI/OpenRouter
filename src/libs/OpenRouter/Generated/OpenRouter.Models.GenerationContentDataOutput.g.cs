
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output from the generation
    /// </summary>
    public sealed partial class GenerationContentDataOutput
    {
        /// <summary>
        /// The completion output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public string? Completion { get; set; }

        /// <summary>
        /// Reasoning/thinking output, if any
        /// </summary>
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
        /// The completion output
        /// </param>
        /// <param name="reasoning">
        /// Reasoning/thinking output, if any
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