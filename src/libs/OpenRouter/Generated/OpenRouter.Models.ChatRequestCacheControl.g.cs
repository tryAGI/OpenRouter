
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequestCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlTtlJsonConverter))]
        public global::OpenRouter.AnthropicCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeJsonConverter))]
        public global::OpenRouter.AnthropicCacheControlDirectiveType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCacheControl" /> class.
        /// </summary>
        /// <param name="ttl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestCacheControl(
            global::OpenRouter.AnthropicCacheControlTtl? ttl,
            global::OpenRouter.AnthropicCacheControlDirectiveType type)
        {
            this.Ttl = ttl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCacheControl" /> class.
        /// </summary>
        public ChatRequestCacheControl()
        {
        }
    }
}