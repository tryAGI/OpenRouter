
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"assigned_by":"user_abc123","created_at":"2025-08-24T10:30:00Z","guardrail_id":"550e8400-e29b-41d4-a716-446655440001","id":"550e8400-e29b-41d4-a716-446655440000","organization_id":"org_xyz789","user_id":"user_abc123"}
    /// </summary>
    public sealed partial class MemberAssignment
    {
        /// <summary>
        /// User ID of who made the assignment<br/>
        /// Example: user_abc123
        /// </summary>
        /// <example>user_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_by")]
        public string? AssignedBy { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the assignment was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ID of the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440001
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GuardrailId { get; set; }

        /// <summary>
        /// Unique identifier for the assignment<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Organization ID<br/>
        /// Example: org_xyz789
        /// </summary>
        /// <example>org_xyz789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Clerk user ID of the assigned member<br/>
        /// Example: user_abc123
        /// </summary>
        /// <example>user_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberAssignment" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the assignment was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="guardrailId">
        /// ID of the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440001
        /// </param>
        /// <param name="id">
        /// Unique identifier for the assignment<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="organizationId">
        /// Organization ID<br/>
        /// Example: org_xyz789
        /// </param>
        /// <param name="userId">
        /// Clerk user ID of the assigned member<br/>
        /// Example: user_abc123
        /// </param>
        /// <param name="assignedBy">
        /// User ID of who made the assignment<br/>
        /// Example: user_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemberAssignment(
            string createdAt,
            global::System.Guid guardrailId,
            global::System.Guid id,
            string organizationId,
            string userId,
            string? assignedBy)
        {
            this.AssignedBy = assignedBy;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.GuardrailId = guardrailId;
            this.Id = id;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberAssignment" /> class.
        /// </summary>
        public MemberAssignment()
        {
        }

    }
}