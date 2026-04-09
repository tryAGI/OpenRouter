
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEndpointsResponseArchitecture
    {
        /// <summary>
        /// Supported input modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.InputModality> InputModalities { get; set; }

        /// <summary>
        /// Instruction format type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InstructType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InstructType2 InstructType { get; set; }

        /// <summary>
        /// Primary modality of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// Supported output modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OutputModality> OutputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ListEndpointsResponseArchitectureTokenizer Tokenizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponseArchitecture" /> class.
        /// </summary>
        /// <param name="inputModalities">
        /// Supported input modalities
        /// </param>
        /// <param name="instructType">
        /// Instruction format type
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
        /// <param name="tokenizer"></param>
        /// <param name="modality">
        /// Primary modality of the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpointsResponseArchitecture(
            global::System.Collections.Generic.IList<global::OpenRouter.InputModality> inputModalities,
            global::OpenRouter.InstructType2 instructType,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModality> outputModalities,
            global::OpenRouter.ListEndpointsResponseArchitectureTokenizer tokenizer,
            string? modality)
        {
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.InstructType = instructType;
            this.Modality = modality;
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Tokenizer = tokenizer ?? throw new global::System.ArgumentNullException(nameof(tokenizer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponseArchitecture" /> class.
        /// </summary>
        public ListEndpointsResponseArchitecture()
        {
        }
    }
}