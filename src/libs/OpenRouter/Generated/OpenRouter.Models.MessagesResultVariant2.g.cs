
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesResultVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        public global::OpenRouter.MessagesResultVariant2ContextManagement? ContextManagement { get; set; }

        /// <summary>
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </summary>
        /// <example>{"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public global::OpenRouter.OpenRouterMetadata? OpenrouterMetadata { get; set; }

        /// <summary>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderNameJsonConverter))]
        public global::OpenRouter.ProviderName? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safeguard_results")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? SafeguardResults { get; set; }

        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}
        /// </summary>
        /// <example>{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesResultVariant2Usage>))]
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesResultVariant2Usage>? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultVariant2" /> class.
        /// </summary>
        /// <param name="contextManagement"></param>
        /// <param name="openrouterMetadata">
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </param>
        /// <param name="provider">
        /// Example: OpenAI
        /// </param>
        /// <param name="safeguardResults"></param>
        /// <param name="usage">
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultVariant2(
            global::OpenRouter.MessagesResultVariant2ContextManagement? contextManagement,
            global::OpenRouter.OpenRouterMetadata? openrouterMetadata,
            global::OpenRouter.ProviderName? provider,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? safeguardResults,
            global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesResultVariant2Usage>? usage)
        {
            this.ContextManagement = contextManagement;
            this.OpenrouterMetadata = openrouterMetadata;
            this.Provider = provider;
            this.SafeguardResults = safeguardResults;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultVariant2" /> class.
        /// </summary>
        public MessagesResultVariant2()
        {
        }

    }
}