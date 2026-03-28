
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Model architecture information
    /// </summary>
    public sealed partial class ModelArchitecture
    {
        /// <summary>
        /// Tokenizer type used by the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelGroupJsonConverter))]
        public global::OpenRouter.ModelGroup? Tokenizer { get; set; }

        /// <summary>
        /// Instruction format type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ModelArchitectureInstructType?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ModelArchitectureInstructType?, object>? InstructType { get; set; }

        /// <summary>
        /// Primary modality of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// Supported input modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.InputModality> InputModalities { get; set; }

        /// <summary>
        /// Supported output modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OutputModality> OutputModalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelArchitecture" /> class.
        /// </summary>
        /// <param name="tokenizer">
        /// Tokenizer type used by the model
        /// </param>
        /// <param name="instructType">
        /// Instruction format type
        /// </param>
        /// <param name="modality">
        /// Primary modality of the model
        /// </param>
        /// <param name="inputModalities">
        /// Supported input modalities
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelArchitecture(
            global::System.Collections.Generic.IList<global::OpenRouter.InputModality> inputModalities,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModality> outputModalities,
            global::OpenRouter.ModelGroup? tokenizer,
            global::OpenRouter.OneOf<global::OpenRouter.ModelArchitectureInstructType?, object>? instructType,
            string? modality)
        {
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Tokenizer = tokenizer;
            this.InstructType = instructType;
            this.Modality = modality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelArchitecture" /> class.
        /// </summary>
        public ModelArchitecture()
        {
        }
    }
}