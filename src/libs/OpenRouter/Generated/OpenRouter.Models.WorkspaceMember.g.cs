
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMember
    {
        /// <summary>
        /// ISO 8601 timestamp of when the membership was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the workspace membership
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Role of the member in the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WorkspaceMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.WorkspaceMemberRole Role { get; set; }

        /// <summary>
        /// Clerk user ID of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// ID of the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMember" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the membership was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the workspace membership
        /// </param>
        /// <param name="role">
        /// Role of the member in the workspace
        /// </param>
        /// <param name="userId">
        /// Clerk user ID of the member
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceMember(
            string createdAt,
            global::System.Guid id,
            global::OpenRouter.WorkspaceMemberRole role,
            string userId,
            global::System.Guid workspaceId)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id;
            this.Role = role;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMember" /> class.
        /// </summary>
        public WorkspaceMember()
        {
        }
    }
}