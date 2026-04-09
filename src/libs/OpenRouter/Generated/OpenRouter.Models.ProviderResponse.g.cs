
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Details of a provider response for a generation attempt
    /// </summary>
    public sealed partial class ProviderResponse
    {
        /// <summary>
        /// Internal endpoint identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// Upstream provider response identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Whether the request used a bring-your-own-key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Response latency in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Canonical model slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        public string? ModelPermaslug { get; set; }

        /// <summary>
        /// Name of the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderResponseProviderNameJsonConverter))]
        public global::OpenRouter.ProviderResponseProviderName? ProviderName { get; set; }

        /// <summary>
        /// HTTP status code from the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResponse" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Internal endpoint identifier
        /// </param>
        /// <param name="id">
        /// Upstream provider response identifier
        /// </param>
        /// <param name="isByok">
        /// Whether the request used a bring-your-own-key
        /// </param>
        /// <param name="latency">
        /// Response latency in milliseconds
        /// </param>
        /// <param name="modelPermaslug">
        /// Canonical model slug
        /// </param>
        /// <param name="providerName">
        /// Name of the provider
        /// </param>
        /// <param name="status">
        /// HTTP status code from the provider
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
            double? status)
        {
            this.EndpointId = endpointId;
            this.Id = id;
            this.IsByok = isByok;
            this.Latency = latency;
            this.ModelPermaslug = modelPermaslug;
            this.ProviderName = providerName;
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