
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkspaceRequest
    {
        /// <summary>
        /// Default image model for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_image_model")]
        public string? DefaultImageModel { get; set; }

        /// <summary>
        /// Default provider sort preference (price, throughput, latency, exacto)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_provider_sort")]
        public string? DefaultProviderSort { get; set; }

        /// <summary>
        /// Default text model for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_text_model")]
        public string? DefaultTextModel { get; set; }

        /// <summary>
        /// Description of the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether data discount logging is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_data_discount_logging_enabled")]
        public bool? IsDataDiscountLoggingEnabled { get; set; }

        /// <summary>
        /// Whether broadcast is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_broadcast_enabled")]
        public bool? IsObservabilityBroadcastEnabled { get; set; }

        /// <summary>
        /// Whether private logging is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_io_logging_enabled")]
        public bool? IsObservabilityIoLoggingEnabled { get; set; }

        /// <summary>
        /// Name for the new workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly slug (lowercase alphanumeric and hyphens only)
        /// </summary>
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
        /// Name for the new workspace
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug (lowercase alphanumeric and hyphens only)
        /// </param>
        /// <param name="defaultImageModel">
        /// Default image model for this workspace
        /// </param>
        /// <param name="defaultProviderSort">
        /// Default provider sort preference (price, throughput, latency, exacto)
        /// </param>
        /// <param name="defaultTextModel">
        /// Default text model for this workspace
        /// </param>
        /// <param name="description">
        /// Description of the workspace
        /// </param>
        /// <param name="isDataDiscountLoggingEnabled">
        /// Whether data discount logging is enabled
        /// </param>
        /// <param name="isObservabilityBroadcastEnabled">
        /// Whether broadcast is enabled
        /// </param>
        /// <param name="isObservabilityIoLoggingEnabled">
        /// Whether private logging is enabled
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
            bool? isDataDiscountLoggingEnabled,
            bool? isObservabilityBroadcastEnabled,
            bool? isObservabilityIoLoggingEnabled)
        {
            this.DefaultImageModel = defaultImageModel;
            this.DefaultProviderSort = defaultProviderSort;
            this.DefaultTextModel = defaultTextModel;
            this.Description = description;
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