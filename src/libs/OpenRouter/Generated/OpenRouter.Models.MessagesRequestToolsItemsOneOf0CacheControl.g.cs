
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItemsOneOf0CacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf0CacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTtlJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf0CacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf0CacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItemsOneOf0CacheControl(
            global::OpenRouter.MessagesRequestToolsItemsOneOf0CacheControlType type,
            global::OpenRouter.MessagesRequestToolsItemsOneOf0CacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf0CacheControl" /> class.
        /// </summary>
        public MessagesRequestToolsItemsOneOf0CacheControl()
        {
        }
    }
}