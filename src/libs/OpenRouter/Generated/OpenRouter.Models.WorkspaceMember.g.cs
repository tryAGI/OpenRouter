
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"created_at":"2025-08-24T10:30:00Z","id":"660e8400-e29b-41d4-a716-446655440000","role":"member","user_id":"user_abc123","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    public sealed partial class WorkspaceMember
    {
        /// <summary>
        /// ISO 8601 timestamp of when the membership was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the workspace membership<br/>
        /// Example: 660e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>660e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Role of the member in the workspace<br/>
        /// Example: member
        /// </summary>
        /// <example>member</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WorkspaceMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.WorkspaceMemberRole Role { get; set; }

        /// <summary>
        /// Clerk user ID of the member<br/>
        /// Example: user_abc123
        /// </summary>
        /// <example>user_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// ID of the workspace<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
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
        /// ISO 8601 timestamp of when the membership was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="id">
        /// Unique identifier for the workspace membership<br/>
        /// Example: 660e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="role">
        /// Role of the member in the workspace<br/>
        /// Example: member
        /// </param>
        /// <param name="userId">
        /// Clerk user ID of the member<br/>
        /// Example: user_abc123
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
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