
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkspaceResponseData
    {
        /// <summary>
        /// ISO 8601 timestamp of when the workspace was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// User ID of the workspace creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

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
        /// Unique identifier for the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether data discount logging is enabled for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_data_discount_logging_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDataDiscountLoggingEnabled { get; set; }

        /// <summary>
        /// Whether broadcast is enabled for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_broadcast_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsObservabilityBroadcastEnabled { get; set; }

        /// <summary>
        /// Whether private logging is enabled for this workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_observability_io_logging_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsObservabilityIoLoggingEnabled { get; set; }

        /// <summary>
        /// Name of the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly slug for the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the workspace was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceResponseData" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the workspace was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the workspace
        /// </param>
        /// <param name="isDataDiscountLoggingEnabled">
        /// Whether data discount logging is enabled for this workspace
        /// </param>
        /// <param name="isObservabilityBroadcastEnabled">
        /// Whether broadcast is enabled for this workspace
        /// </param>
        /// <param name="isObservabilityIoLoggingEnabled">
        /// Whether private logging is enabled for this workspace
        /// </param>
        /// <param name="name">
        /// Name of the workspace
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug for the workspace
        /// </param>
        /// <param name="createdBy">
        /// User ID of the workspace creator
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
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the workspace was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkspaceResponseData(
            string createdAt,
            global::System.Guid id,
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
            string? updatedAt)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy;
            this.DefaultImageModel = defaultImageModel;
            this.DefaultProviderSort = defaultProviderSort;
            this.DefaultTextModel = defaultTextModel;
            this.Description = description;
            this.Id = id;
            this.IsDataDiscountLoggingEnabled = isDataDiscountLoggingEnabled;
            this.IsObservabilityBroadcastEnabled = isObservabilityBroadcastEnabled;
            this.IsObservabilityIoLoggingEnabled = isObservabilityIoLoggingEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceResponseData" /> class.
        /// </summary>
        public GetWorkspaceResponseData()
        {
        }
    }
}