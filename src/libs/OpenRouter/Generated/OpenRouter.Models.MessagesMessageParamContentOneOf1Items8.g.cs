
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items8
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content Content { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeJsonConverter))]
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items8" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1Items8(
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content content,
            string toolUseId,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type type)
        {
            this.CacheControl = cacheControl;
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items8" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items8()
        {
        }
    }
}