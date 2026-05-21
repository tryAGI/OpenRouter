
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// tool_search_tool_result_error variant
    /// </summary>
    public sealed partial class AnthropicToolSearchContentVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchResultErrorTypeJsonConverter))]
        public global::OpenRouter.AnthropicToolSearchResultErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicServerToolErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicServerToolErrorCode ErrorCode { get; set; }

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
        /// Initializes a new instance of the <see cref="AnthropicToolSearchContentVariant1" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicToolSearchContentVariant1(
            global::OpenRouter.AnthropicServerToolErrorCode errorCode,
            global::OpenRouter.AnthropicToolSearchResultErrorType type,
            string? errorMessage)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchContentVariant1" /> class.
        /// </summary>
        public AnthropicToolSearchContentVariant1()
        {
        }

    }
}