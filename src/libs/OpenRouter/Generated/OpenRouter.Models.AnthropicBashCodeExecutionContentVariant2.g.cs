
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// bash_code_execution_tool_result_error variant
    /// </summary>
    public sealed partial class AnthropicBashCodeExecutionContentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorTypeJsonConverter))]
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBashCodeExecutionContentVariant2" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicBashCodeExecutionContentVariant2(
            global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode errorCode,
            global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBashCodeExecutionContentVariant2" /> class.
        /// </summary>
        public AnthropicBashCodeExecutionContentVariant2()
        {
        }

    }
}