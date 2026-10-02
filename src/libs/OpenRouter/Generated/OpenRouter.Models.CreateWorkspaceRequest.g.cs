
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"default_image_model":"openai/dall-e-3","default_provider_sort":"price","default_text_model":"openai/gpt-4o","description":"Production environment workspace","name":"Production","slug":"production"}
    /// </summary>
    public sealed partial class CreateWorkspaceRequest
    {
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
        /// OpenRouter server tools that requests in this workspace may not invoke. Requests naming a disabled tool are rejected with 403. An empty array or null clears the list.<br/>
        /// Example: [openrouter:web_search, openrouter:bash]
        /// </summary>
        /// <example>[openrouter:web_search, openrouter:bash]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_server_tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? DisabledServerTools { get; set; }

        /// <summary>
        /// Optional array of API key IDs to filter I/O logging<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("io_logging_api_key_ids")]
        public global::System.Collections.Generic.IList<int>? IoLoggingApiKeyIds { get; set; }

        /// <summary>
        /// Sampling rate for I/O logging (0.0001-1)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("io_logging_sampling_rate")]
        public double? IoLoggingSamplingRate { get; set; }

        /// <summary>
        /// Whether data discount logging is enabled<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_data_discount_logging_enabled")]
        public bool? IsDataDiscountLoggingEnabled { get; set; }

        /// <summary>
        /// Whether broadcast is enabled<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_broadcast_enabled")]
        public bool? IsObservabilityBroadcastEnabled { get; set; }

        /// <summary>
        /// Whether private logging is enabled<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_io_logging_enabled")]
        public bool? IsObservabilityIoLoggingEnabled { get; set; }

        /// <summary>
        /// Name for the new workspace<br/>
        /// Example: Production
        /// </summary>
        /// <example>Production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly slug (lowercase alphanumeric segments separated by single hyphens, no leading/trailing hyphens)<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new workspace<br/>
        /// Example: Production
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug (lowercase alphanumeric segments separated by single hyphens, no leading/trailing hyphens)<br/>
        /// Example: production
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
        /// OpenRouter server tools that requests in this workspace may not invoke. Requests naming a disabled tool are rejected with 403. An empty array or null clears the list.<br/>
        /// Example: [openrouter:web_search, openrouter:bash]
        /// </param>
        /// <param name="ioLoggingApiKeyIds">
        /// Optional array of API key IDs to filter I/O logging<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ioLoggingSamplingRate">
        /// Sampling rate for I/O logging (0.0001-1)<br/>
        /// Example: 1
        /// </param>
        /// <param name="isDataDiscountLoggingEnabled">
        /// Whether data discount logging is enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="isObservabilityBroadcastEnabled">
        /// Whether broadcast is enabled<br/>
        /// Example: false
        /// </param>
        /// <param name="isObservabilityIoLoggingEnabled">
        /// Whether private logging is enabled<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkspaceRequest(
            string name,
            string slug,
            string? defaultImageModel,
            string? defaultProviderSort,
            string? defaultTextModel,
            string? description,
            global::System.Collections.Generic.IList<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? disabledServerTools,
            global::System.Collections.Generic.IList<int>? ioLoggingApiKeyIds,
            double? ioLoggingSamplingRate,
            bool? isDataDiscountLoggingEnabled,
            bool? isObservabilityBroadcastEnabled,
            bool? isObservabilityIoLoggingEnabled)
        {
            this.DefaultImageModel = defaultImageModel;
            this.DefaultProviderSort = defaultProviderSort;
            this.DefaultTextModel = defaultTextModel;
            this.Description = description;
            this.DisabledServerTools = disabledServerTools;
            this.IoLoggingApiKeyIds = ioLoggingApiKeyIds;
            this.IoLoggingSamplingRate = ioLoggingSamplingRate;
            this.IsDataDiscountLoggingEnabled = isDataDiscountLoggingEnabled;
            this.IsObservabilityBroadcastEnabled = isObservabilityBroadcastEnabled;
            this.IsObservabilityIoLoggingEnabled = isObservabilityIoLoggingEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkspaceRequest" /> class.
        /// </summary>
        public CreateWorkspaceRequest()
        {
        }

    }
}