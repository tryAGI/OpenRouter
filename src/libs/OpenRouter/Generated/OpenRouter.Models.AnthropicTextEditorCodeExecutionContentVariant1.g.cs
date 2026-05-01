
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text_editor_code_execution_create_result variant
    /// </summary>
    public sealed partial class AnthropicTextEditorCodeExecutionContentVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionCreateResultTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_file_update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFileUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant1" /> class.
        /// </summary>
        /// <param name="isFileUpdate"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextEditorCodeExecutionContentVariant1(
            bool isFileUpdate,
            global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType type)
        {
            this.Type = type;
            this.IsFileUpdate = isFileUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant1" /> class.
        /// </summary>
        public AnthropicTextEditorCodeExecutionContentVariant1()
        {
        }
    }
}