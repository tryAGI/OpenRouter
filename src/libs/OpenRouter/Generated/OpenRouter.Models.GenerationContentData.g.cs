
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stored prompt and completion content
    /// </summary>
    public sealed partial class GenerationContentData
    {
        /// <summary>
        /// The input to the generation — either a prompt string or an array of messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GenerationContentDataInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GenerationContentDataInput Input { get; set; }

        /// <summary>
        /// The output from the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GenerationContentDataOutput Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentData" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to the generation — either a prompt string or an array of messages
        /// </param>
        /// <param name="output">
        /// The output from the generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentData(
            global::OpenRouter.GenerationContentDataInput input,
            global::OpenRouter.GenerationContentDataOutput output)
        {
            this.Input = input;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentData" /> class.
        /// </summary>
        public GenerationContentData()
        {
        }
    }
}