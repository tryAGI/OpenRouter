
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// code_execution_tool_result_error variant
    /// </summary>
    public sealed partial class AnthropicCodeExecutionContentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionToolResultErrorTypeJsonConverter))]
        public global::OpenRouter.AnthropicCodeExecutionToolResultErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicServerToolErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicServerToolErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCodeExecutionContentVariant2" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicCodeExecutionContentVariant2(
            global::OpenRouter.AnthropicServerToolErrorCode errorCode,
            global::OpenRouter.AnthropicCodeExecutionToolResultErrorType type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCodeExecutionContentVariant2" /> class.
        /// </summary>
        public AnthropicCodeExecutionContentVariant2()
        {
        }
    }
}