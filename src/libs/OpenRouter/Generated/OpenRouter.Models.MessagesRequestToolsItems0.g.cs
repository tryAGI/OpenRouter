
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesRequestToolsItemsOneOf0InputSchema InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolsItemsOneOf0Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems0" /> class.
        /// </summary>
        /// <param name="inputSchema"></param>
        /// <param name="name"></param>
        /// <param name="cacheControl"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItems0(
            global::OpenRouter.MessagesRequestToolsItemsOneOf0InputSchema inputSchema,
            string name,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            string? description,
            global::OpenRouter.MessagesRequestToolsItemsOneOf0Type? type)
        {
            this.CacheControl = cacheControl;
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems0" /> class.
        /// </summary>
        public MessagesRequestToolsItems0()
        {
        }
    }
}