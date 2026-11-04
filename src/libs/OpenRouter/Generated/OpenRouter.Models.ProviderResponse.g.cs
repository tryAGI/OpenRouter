
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Details of a provider response for a generation attempt<br/>
    /// Example: {"endpoint_id":"ep_abc123","id":"chatcmpl-abc123","is_byok":false,"latency":1200,"model_permaslug":"openai/gpt-4","provider_name":"OpenAI","status":200}
    /// </summary>
    public sealed partial class ProviderResponse
    {
        /// <summary>
        /// Internal endpoint identifier<br/>
        /// Example: ep_abc123
        /// </summary>
        /// <example>ep_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Upstream provider response identifier<br/>
        /// Example: chatcmpl-abc123
        /// </summary>
        /// <example>chatcmpl-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Whether the request used a bring-your-own-key<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Response latency in milliseconds<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Canonical model slug<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        public string? ModelPermaslug { get; set; }

        /// <summary>
        /// Name of the provider<br/>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderResponseProviderNameJsonConverter))]
        public global::OpenRouter.ProviderResponseProviderName? ProviderName { get; set; }

        /// <summary>
        /// The service tier this request was routed to (e.g. flex, priority). The tier actually applied and billed is determined by the provider response and may differ.<br/>
        /// Example: priority
        /// </summary>
        /// <example>priority</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderResponseRoutedServiceTierJsonConverter))]
        public global::OpenRouter.ProviderResponseRoutedServiceTier? RoutedServiceTier { get; set; }

        /// <summary>
        /// HTTP status code from the provider<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResponse" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Internal endpoint identifier<br/>
        /// Example: ep_abc123
        /// </param>
        /// <param name="id">
        /// Upstream provider response identifier<br/>
        /// Example: chatcmpl-abc123
        /// </param>
        /// <param name="isByok">
        /// Whether the request used a bring-your-own-key<br/>
        /// Example: false
        /// </param>
        /// <param name="latency">
        /// Response latency in milliseconds<br/>
        /// Example: 1200
        /// </param>
        /// <param name="modelPermaslug">
        /// Canonical model slug<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="providerName">
        /// Name of the provider<br/>
        /// Example: OpenAI
        /// </param>
        /// <param name="routedServiceTier">
        /// The service tier this request was routed to (e.g. flex, priority). The tier actually applied and billed is determined by the provider response and may differ.<br/>
        /// Example: priority
        /// </param>
        /// <param name="status">
        /// HTTP status code from the provider<br/>
        /// Example: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderResponse(
            string? endpointId,
            string? id,
            bool? isByok,
            double? latency,
            string? modelPermaslug,
            global::OpenRouter.ProviderResponseProviderName? providerName,
            global::OpenRouter.ProviderResponseRoutedServiceTier? routedServiceTier,
            int? status)
        {
            this.EndpointId = endpointId;
            this.Id = id;
            this.IsByok = isByok;
            this.Latency = latency;
            this.ModelPermaslug = modelPermaslug;
            this.ProviderName = providerName;
            this.RoutedServiceTier = routedServiceTier;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResponse" /> class.
        /// </summary>
        public ProviderResponse()
        {
        }

    }
}