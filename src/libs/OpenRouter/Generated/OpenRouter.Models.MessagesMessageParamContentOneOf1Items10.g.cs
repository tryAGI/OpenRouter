
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeJsonConverter))]
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items10" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1Items10(
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type type,
            string? content,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl)
        {
            this.Type = type;
            this.Content = content;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items10" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items10()
        {
        }
    }
}