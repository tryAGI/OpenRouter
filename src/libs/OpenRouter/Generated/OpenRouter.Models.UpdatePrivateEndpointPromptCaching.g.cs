
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Change only the named prompt-caching flags; omitted flags keep their stored value.<br/>
    /// Example: {"cache_control":true}
    /// </summary>
    public sealed partial class UpdatePrivateEndpointPromptCaching
    {
        /// <summary>
        /// Forward top-level, message, and tool cache_control markers. Defaults on after endpoint validation accepts these fields; otherwise off. Set false to opt out, or true to declare support explicitly.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public bool? CacheControl { get; set; }

        /// <summary>
        /// Send an OpenRouter-derived, customer-isolated prompt_cache_key, not the caller-supplied key. Defaults on after endpoint validation accepts the field; otherwise off. Set false to opt out, or true to declare support explicitly. HIPAA and unknown workspace posture withhold OpenRouter caching directives and the derived key; this does not control upstream retention.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public bool? PromptCacheKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointPromptCaching" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Forward top-level, message, and tool cache_control markers. Defaults on after endpoint validation accepts these fields; otherwise off. Set false to opt out, or true to declare support explicitly.<br/>
        /// Example: false
        /// </param>
        /// <param name="promptCacheKey">
        /// Send an OpenRouter-derived, customer-isolated prompt_cache_key, not the caller-supplied key. Defaults on after endpoint validation accepts the field; otherwise off. Set false to opt out, or true to declare support explicitly. HIPAA and unknown workspace posture withhold OpenRouter caching directives and the derived key; this does not control upstream retention.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateEndpointPromptCaching(
            bool? cacheControl,
            bool? promptCacheKey)
        {
            this.CacheControl = cacheControl;
            this.PromptCacheKey = promptCacheKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointPromptCaching" /> class.
        /// </summary>
        public UpdatePrivateEndpointPromptCaching()
        {
        }

    }
}