
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequestToolVariant6
    {
        /// <summary>
        /// Example: [direct]
        /// </summary>
        /// <example>[direct]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
        /// <example>{"type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caching")]
        public global::OpenRouter.AnthropicCacheControlDirective? Caching { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolVariant6NameJsonConverter))]
        public global::OpenRouter.MessagesRequestToolVariant6Name Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolVariant6TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolVariant6Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolVariant6" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="allowedCallers">
        /// Example: [direct]
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="caching"></param>
        /// <param name="deferLoading"></param>
        /// <param name="maxUses"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolVariant6(
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCaller>? allowedCallers,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.AnthropicCacheControlDirective? caching,
            bool? deferLoading,
            int? maxUses,
            global::OpenRouter.MessagesRequestToolVariant6Name name,
            global::OpenRouter.MessagesRequestToolVariant6Type type)
        {
            this.AllowedCallers = allowedCallers;
            this.CacheControl = cacheControl;
            this.Caching = caching;
            this.DeferLoading = deferLoading;
            this.MaxUses = maxUses;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolVariant6" /> class.
        /// </summary>
        public MessagesRequestToolVariant6()
        {
        }

    }
}