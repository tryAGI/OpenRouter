
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// image variant
    /// </summary>
    public sealed partial class AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeJsonConverter))]
        public global::OpenRouter.AnthropicImageBlockParamType Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1(
            global::OpenRouter.AnthropicImageBlockParamSource source,
            global::OpenRouter.AnthropicImageBlockParamType type,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl)
        {
            this.Type = type;
            this.CacheControl = cacheControl;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1" /> class.
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1()
        {
        }

    }
}