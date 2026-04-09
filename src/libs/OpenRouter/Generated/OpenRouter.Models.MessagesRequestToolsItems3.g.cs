
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItems3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf3Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.AnthropicWebSearchToolUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems3" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="blockedDomains"></param>
        /// <param name="cacheControl"></param>
        /// <param name="maxUses"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="userLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItems3(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            int? maxUses,
            global::OpenRouter.MessagesRequestToolsItemsOneOf3Name name,
            global::OpenRouter.MessagesRequestToolsItemsOneOf3Type type,
            global::OpenRouter.AnthropicWebSearchToolUserLocation? userLocation)
        {
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.CacheControl = cacheControl;
            this.MaxUses = maxUses;
            this.Name = name;
            this.Type = type;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems3" /> class.
        /// </summary>
        public MessagesRequestToolsItems3()
        {
        }
    }
}