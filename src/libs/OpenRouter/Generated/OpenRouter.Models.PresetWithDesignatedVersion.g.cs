
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A preset with its currently designated version.
    /// </summary>
    public sealed partial class PresetWithDesignatedVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A specific version of a preset, containing config and optional system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("designated_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PresetDesignatedVersion DesignatedVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("designated_version_id")]
        public string? DesignatedVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PresetWithDesignatedVersionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PresetWithDesignatedVersionStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updated_at")]
        public string? StatusUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetWithDesignatedVersion" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="designatedVersion">
        /// A specific version of a preset, containing config and optional system prompt.
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creatorUserId"></param>
        /// <param name="description"></param>
        /// <param name="designatedVersionId"></param>
        /// <param name="statusUpdatedAt"></param>
        /// <param name="workspaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresetWithDesignatedVersion(
            string createdAt,
            global::OpenRouter.PresetDesignatedVersion designatedVersion,
            string id,
            string name,
            string slug,
            global::OpenRouter.PresetWithDesignatedVersionStatus status,
            string updatedAt,
            string? creatorUserId,
            string? description,
            string? designatedVersionId,
            string? statusUpdatedAt,
            string? workspaceId)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatorUserId = creatorUserId;
            this.Description = description;
            this.DesignatedVersion = designatedVersion ?? throw new global::System.ArgumentNullException(nameof(designatedVersion));
            this.DesignatedVersionId = designatedVersionId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Status = status;
            this.StatusUpdatedAt = statusUpdatedAt;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetWithDesignatedVersion" /> class.
        /// </summary>
        public PresetWithDesignatedVersion()
        {
        }

    }
}