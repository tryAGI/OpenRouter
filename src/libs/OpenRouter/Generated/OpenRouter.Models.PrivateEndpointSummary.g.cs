
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointSummary
    {
        /// <summary>
        /// ISO timestamp of when the endpoint was created.<br/>
        /// Example: 2026-09-24T10:30:00Z
        /// </summary>
        /// <example>2026-09-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </summary>
        /// <example>5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Display name of the model, or `null` when the model is no longer listed.<br/>
        /// Example: OpenAI: GPT-4o
        /// </summary>
        /// <example>OpenAI: GPT-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </summary>
        /// <example>openai/gpt-4o-2024-08-06</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Public model slug, or `null` when the model is no longer listed.<br/>
        /// Example: openai/gpt-4o
        /// </summary>
        /// <example>openai/gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_slug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// Display name of the upstream provider.<br/>
        /// Example: Azure
        /// </summary>
        /// <example>Azure</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Lifecycle state. `draft` endpoints are not routable until validated and activated; `disabled` endpoints are activated but temporarily not routable.<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSummary" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO timestamp of when the endpoint was created.<br/>
        /// Example: 2026-09-24T10:30:00Z
        /// </param>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="modelPermaslug">
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </param>
        /// <param name="providerName">
        /// Display name of the upstream provider.<br/>
        /// Example: Azure
        /// </param>
        /// <param name="status">
        /// Lifecycle state. `draft` endpoints are not routable until validated and activated; `disabled` endpoints are activated but temporarily not routable.<br/>
        /// Example: active
        /// </param>
        /// <param name="modelName">
        /// Display name of the model, or `null` when the model is no longer listed.<br/>
        /// Example: OpenAI: GPT-4o
        /// </param>
        /// <param name="modelSlug">
        /// Public model slug, or `null` when the model is no longer listed.<br/>
        /// Example: openai/gpt-4o
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointSummary(
            string createdAt,
            global::System.Guid id,
            string modelPermaslug,
            string providerName,
            global::OpenRouter.PrivateEndpointStatus status,
            string? modelName,
            string? modelSlug)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id;
            this.ModelName = modelName;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.ModelSlug = modelSlug;
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSummary" /> class.
        /// </summary>
        public PrivateEndpointSummary()
        {
        }

    }
}