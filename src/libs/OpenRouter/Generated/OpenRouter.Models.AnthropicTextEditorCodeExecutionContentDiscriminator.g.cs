
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicTextEditorCodeExecutionContentDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionContentDiscriminatorTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextEditorCodeExecutionContentDiscriminator(
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentDiscriminator" /> class.
        /// </summary>
        public AnthropicTextEditorCodeExecutionContentDiscriminator()
        {
        }

    }
}