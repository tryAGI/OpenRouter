
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
        /// Instruction format type<br/>
        /// Example: chatml
        /// </summary>
        /// <example>chatml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InstructTypeJsonConverter))]
        public global::OpenRouter.InstructType? InstructType { get; set; }

        /// <summary>
        /// Primary modality of the model<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
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
        public global::OpenRouter.ModelGroup? Tokenizer { get; set; }

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
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
        /// <param name="instructType">
        /// Instruction format type<br/>
        /// Example: chatml
        /// </param>
        /// <param name="modality">
        /// Primary modality of the model<br/>
        /// Example: text
        /// </param>
        /// <param name="tokenizer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpointsResponseArchitecture(
            global::System.Collections.Generic.IList<global::OpenRouter.InputModality> inputModalities,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModality> outputModalities,
            global::OpenRouter.InstructType? instructType,
            string? modality,
            global::OpenRouter.ModelGroup? tokenizer)
        {
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.InstructType = instructType;
            this.Modality = modality;
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Tokenizer = tokenizer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponseArchitecture" /> class.
        /// </summary>
        public ListEndpointsResponseArchitecture()
        {
        }

    }
}