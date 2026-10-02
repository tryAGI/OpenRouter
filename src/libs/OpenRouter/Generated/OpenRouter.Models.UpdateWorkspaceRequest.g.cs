
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"name":"Updated Workspace","slug":"updated-workspace"}
    /// </summary>
    public sealed partial class UpdateWorkspaceRequest
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
        /// New description for the workspace<br/>
        /// Example: Updated description
        /// </summary>
        /// <example>Updated description</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// OpenRouter server tools that requests in this workspace may not invoke. Requests naming a disabled tool are rejected with 403. An empty array or null clears the list.<br/>
        /// Example: [openrouter:web_search, openrouter:bash]
        /// </summary>
        /// <example>[openrouter:web_search, openrouter:bash]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_server_tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? DisabledServerTools { get; set; }

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
        /// New name for the workspace<br/>
        /// Example: Updated Workspace
        /// </summary>
        /// <example>Updated Workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New URL-friendly slug (lowercase alphanumeric segments separated by single hyphens, no leading/trailing hyphens)<br/>
        /// Example: updated-workspace
        /// </summary>
        /// <example>updated-workspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkspaceRequest" /> class.
        /// </summary>
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
        /// New description for the workspace<br/>
        /// Example: Updated description
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
        /// <param name="name">
        /// New name for the workspace<br/>
        /// Example: Updated Workspace
        /// </param>
        /// <param name="slug">
        /// New URL-friendly slug (lowercase alphanumeric segments separated by single hyphens, no leading/trailing hyphens)<br/>
        /// Example: updated-workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWorkspaceRequest(
            string? defaultImageModel,
            string? defaultProviderSort,
            string? defaultTextModel,
            string? description,
            global::System.Collections.Generic.IList<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? disabledServerTools,
            global::System.Collections.Generic.IList<int>? ioLoggingApiKeyIds,
            double? ioLoggingSamplingRate,
            bool? isDataDiscountLoggingEnabled,
            bool? isObservabilityBroadcastEnabled,
            bool? isObservabilityIoLoggingEnabled,
            string? name,
            string? slug)
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
            this.Name = name;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkspaceRequest" /> class.
        /// </summary>
        public UpdateWorkspaceRequest()
        {
        }

    }
}