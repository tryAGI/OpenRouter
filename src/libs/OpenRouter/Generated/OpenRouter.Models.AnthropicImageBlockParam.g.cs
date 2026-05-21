
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicImageBlockParam
    {
        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicImageBlockParamSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeJsonConverter))]
        public global::OpenRouter.AnthropicImageBlockParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageBlockParam" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicImageBlockParam(
            global::OpenRouter.AnthropicImageBlockParamSource source,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.AnthropicImageBlockParamType type)
        {
            this.CacheControl = cacheControl;
            this.Source = source;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageBlockParam" /> class.
        /// </summary>
        public AnthropicImageBlockParam()
        {
        }

    }
}