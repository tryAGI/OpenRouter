
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicToolSearchToolRegex
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
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchToolRegexNameJsonConverter))]
        public global::OpenRouter.AnthropicToolSearchToolRegexName Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchToolRegexTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicToolSearchToolRegexType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchToolRegex" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="allowedCallers">
        /// Example: [direct]
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="deferLoading"></param>
        /// <param name="name"></param>
        /// <param name="strict"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicToolSearchToolRegex(
            global::OpenRouter.AnthropicToolSearchToolRegexType type,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCaller>? allowedCallers,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            bool? deferLoading,
            global::OpenRouter.AnthropicToolSearchToolRegexName name,
            bool? strict)
        {
            this.AllowedCallers = allowedCallers;
            this.CacheControl = cacheControl;
            this.DeferLoading = deferLoading;
            this.Name = name;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicToolSearchToolRegex" /> class.
        /// </summary>
        public AnthropicToolSearchToolRegex()
        {
        }

    }
}