
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text_editor_code_execution_tool_result_error variant
    /// </summary>
    public sealed partial class AnthropicTextEditorCodeExecutionContentVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant3" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextEditorCodeExecutionContentVariant3(
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode errorCode,
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType type,
            string? errorMessage)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextEditorCodeExecutionContentVariant3" /> class.
        /// </summary>
        public AnthropicTextEditorCodeExecutionContentVariant3()
        {
        }
    }
}