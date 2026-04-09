
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentJsonConverter))]
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Content? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeJsonConverter))]
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items4" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="cacheControl"></param>
        /// <param name="content"></param>
        /// <param name="isError"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1Items4(
            string toolUseId,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Content? content,
            bool? isError,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type type)
        {
            this.CacheControl = cacheControl;
            this.Content = content;
            this.IsError = isError;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items4" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items4()
        {
        }
    }
}