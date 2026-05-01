
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// web_fetch_tool_result_error variant
    /// </summary>
    public sealed partial class AnthropicWebFetchContentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorTypeJsonConverter))]
        public global::OpenRouter.AnthropicWebFetchToolResultErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicWebFetchContentVariant2" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicWebFetchContentVariant2(
            global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode errorCode,
            global::OpenRouter.AnthropicWebFetchToolResultErrorType type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicWebFetchContentVariant2" /> class.
        /// </summary>
        public AnthropicWebFetchContentVariant2()
        {
        }
    }
}