
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// web-fetch variant
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItemsVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebFetchPluginIdJsonConverter))]
        public global::OpenRouter.WebFetchPluginId Id { get; set; }

        /// <summary>
        /// Only fetch from these domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Never fetch from these domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// Maximum content length in approximate tokens. Content exceeding this limit is truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_tokens")]
        public int? MaxContentTokens { get; set; }

        /// <summary>
        /// Maximum number of web fetches per request. Once exceeded, the tool returns an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant10" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowedDomains">
        /// Only fetch from these domains.
        /// </param>
        /// <param name="blockedDomains">
        /// Never fetch from these domains.
        /// </param>
        /// <param name="maxContentTokens">
        /// Maximum content length in approximate tokens. Content exceeding this limit is truncated.
        /// </param>
        /// <param name="maxUses">
        /// Maximum number of web fetches per request. Once exceeded, the tool returns an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestPluginsItemsVariant10(
            global::OpenRouter.WebFetchPluginId id,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            int? maxContentTokens,
            int? maxUses)
        {
            this.Id = id;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.MaxContentTokens = maxContentTokens;
            this.MaxUses = maxUses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant10" /> class.
        /// </summary>
        public ResponsesRequestPluginsItemsVariant10()
        {
        }

    }
}