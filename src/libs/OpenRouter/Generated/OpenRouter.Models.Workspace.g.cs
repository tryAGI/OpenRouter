
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"created_at":"2025-08-24T10:30:00Z","created_by":"user_abc123","default_guardrail_id":"595d5849-7e86-51fd-a7c0-705c34e4afff","default_image_model":"openai/dall-e-3","default_provider_sort":"price","default_text_model":"openai/gpt-4o","description":"Production environment workspace","disabled_server_tools":null,"id":"550e8400-e29b-41d4-a716-446655440000","include_byok_in_budgets":false,"io_logging_api_key_ids":null,"io_logging_sampling_rate":1,"is_data_discount_logging_enabled":true,"is_observability_broadcast_enabled":false,"is_observability_io_logging_enabled":false,"name":"Production","slug":"production","updated_at":"2025-08-24T15:45:00Z"}
    /// </summary>
    public sealed partial class Workspace
    {
        /// <summary>
        /// ISO 8601 timestamp of when the workspace was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// User ID of the workspace creator<br/>
        /// Example: user_abc123
        /// </summary>
        /// <example>user_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Deterministic ID derived from the workspace ID. The default guardrail is materialized when its configuration is first written.<br/>
        /// Example: 595d5849-7e86-51fd-a7c0-705c34e4afff
        /// </summary>
        /// <example>595d5849-7e86-51fd-a7c0-705c34e4afff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DefaultGuardrailId { get; set; }

        /// <summary>
        /// Default image model for this workspace<br/>
        /// Example: openai/dall-e-3
        /// </summary>
        /// <example>openai/dall-e-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_image_model")]
        public string? DefaultImageModel { get; set; }

        /// <summary>
        /// Default provider sort preference (price, throughput, latency, exacto)<br/>
        /// Example: price
        /// </summary>
        /// <example>price</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_provider_sort")]
        public string? DefaultProviderSort { get; set; }

        /// <summary>
        /// Default text model for this workspace<br/>
        /// Example: openai/gpt-4o
        /// </summary>
        /// <example>openai/gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_text_model")]
        public string? DefaultTextModel { get; set; }

        /// <summary>
        /// Description of the workspace<br/>
        /// Example: Production environment workspace
        /// </summary>
        /// <example>Production environment workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// OpenRouter server tools (e.g. openrouter:web_search) that requests in this workspace may not invoke. Null means no tools are disabled.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_server_tools")]
        public global::System.Collections.Generic.IList<string>? DisabledServerTools { get; set; }

        /// <summary>
        /// Unique identifier for the workspace<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether BYOK (bring-your-own-key) spend counts toward this workspace's budgets. Set it via the workspace budget endpoints.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        public bool? IncludeByokInBudgets { get; set; }

        /// <summary>
        /// Optional array of API key IDs to filter I/O logging. Null means all keys are logged.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("io_logging_api_key_ids")]
        public global::System.Collections.Generic.IList<int>? IoLoggingApiKeyIds { get; set; }

        /// <summary>
        /// Sampling rate for I/O logging (0.0001-1). 1 means 100% of requests are logged.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("io_logging_sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IoLoggingSamplingRate { get; set; }

        /// <summary>
        /// Whether data discount logging is enabled for this workspace<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_data_discount_logging_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDataDiscountLoggingEnabled { get; set; }

        /// <summary>
        /// Whether broadcast is enabled for this workspace<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_broadcast_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsObservabilityBroadcastEnabled { get; set; }

        /// <summary>
        /// Whether private logging is enabled for this workspace<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_io_logging_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsObservabilityIoLoggingEnabled { get; set; }

        /// <summary>
        /// Name of the workspace<br/>
        /// Example: Production
        /// </summary>
        /// <example>Production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly slug for the workspace<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the workspace was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </summary>
        /// <example>2025-08-24T15:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the workspace was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="defaultGuardrailId">
        /// Deterministic ID derived from the workspace ID. The default guardrail is materialized when its configuration is first written.<br/>
        /// Example: 595d5849-7e86-51fd-a7c0-705c34e4afff
        /// </param>
        /// <param name="id">
        /// Unique identifier for the workspace<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="ioLoggingSamplingRate">
        /// Sampling rate for I/O logging (0.0001-1). 1 means 100% of requests are logged.<br/>
        /// Example: 1
        /// </param>
        /// <param name="isDataDiscountLoggingEnabled">
        /// Whether data discount logging is enabled for this workspace<br/>
        /// Example: true
        /// </param>
        /// <param name="isObservabilityBroadcastEnabled">
        /// Whether broadcast is enabled for this workspace<br/>
        /// Example: false
        /// </param>
        /// <param name="isObservabilityIoLoggingEnabled">
        /// Whether private logging is enabled for this workspace<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// Name of the workspace<br/>
        /// Example: Production
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug for the workspace<br/>
        /// Example: production
        /// </param>
        /// <param name="createdBy">
        /// User ID of the workspace creator<br/>
        /// Example: user_abc123
        /// </param>
        /// <param name="defaultImageModel">
        /// Default image model for this workspace<br/>
        /// Example: openai/dall-e-3
        /// </param>
        /// <param name="defaultProviderSort">
        /// Default provider sort preference (price, throughput, latency, exacto)<br/>
        /// Example: price
        /// </param>
        /// <param name="defaultTextModel">
        /// Default text model for this workspace<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="description">
        /// Description of the workspace<br/>
        /// Example: Production environment workspace
        /// </param>
        /// <param name="disabledServerTools">
        /// OpenRouter server tools (e.g. openrouter:web_search) that requests in this workspace may not invoke. Null means no tools are disabled.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includeByokInBudgets">
        /// Whether BYOK (bring-your-own-key) spend counts toward this workspace's budgets. Set it via the workspace budget endpoints.<br/>
        /// Example: false
        /// </param>
        /// <param name="ioLoggingApiKeyIds">
        /// Optional array of API key IDs to filter I/O logging. Null means all keys are logged.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the workspace was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Workspace(
            string createdAt,
            global::System.Guid defaultGuardrailId,
            global::System.Guid id,
            double ioLoggingSamplingRate,
            bool isDataDiscountLoggingEnabled,
            bool isObservabilityBroadcastEnabled,
            bool isObservabilityIoLoggingEnabled,
            string name,
            string slug,
            string? createdBy,
            string? defaultImageModel,
            string? defaultProviderSort,
            string? defaultTextModel,
            string? description,
            global::System.Collections.Generic.IList<string>? disabledServerTools,
            bool? includeByokInBudgets,
            global::System.Collections.Generic.IList<int>? ioLoggingApiKeyIds,
            string? updatedAt)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.DefaultGuardrailId = defaultGuardrailId;
            this.DefaultImageModel = defaultImageModel;
            this.DefaultProviderSort = defaultProviderSort;
            this.DefaultTextModel = defaultTextModel;
            this.Description = description;
            this.DisabledServerTools = disabledServerTools;
            this.Id = id;
            this.IncludeByokInBudgets = includeByokInBudgets;
            this.IoLoggingApiKeyIds = ioLoggingApiKeyIds;
            this.IoLoggingSamplingRate = ioLoggingSamplingRate;
            this.IsDataDiscountLoggingEnabled = isDataDiscountLoggingEnabled;
            this.IsObservabilityBroadcastEnabled = isObservabilityBroadcastEnabled;
            this.IsObservabilityIoLoggingEnabled = isObservabilityIoLoggingEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        public Workspace()
        {
        }

    }
}