
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf4Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems>? AllowedCallers { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.PreviewWebSearchUserLocation? UserLocation { get; set; }

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
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="blockedDomains"></param>
        /// <param name="maxUses"></param>
        /// <param name="userLocation"></param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItems4(
            global::OpenRouter.MessagesRequestToolsItemsOneOf4Type type,
            global::OpenRouter.MessagesRequestToolsItemsOneOf4Name name,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems>? allowedCallers,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            int? maxUses,
            global::OpenRouter.PreviewWebSearchUserLocation? userLocation,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl)
        {
            this.Type = type;
            this.Name = name;
            this.AllowedCallers = allowedCallers;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.MaxUses = maxUses;
            this.UserLocation = userLocation;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems4" /> class.
        /// </summary>
        public MessagesRequestToolsItems4()
        {
        }
    }
}