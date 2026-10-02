
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"assigned_by":"user_abc123","created_at":"2025-08-24T10:30:00Z","guardrail_id":"550e8400-e29b-41d4-a716-446655440001","id":"550e8400-e29b-41d4-a716-446655440000","key_hash":"c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93","key_label":"prod-key","key_name":"Production Key"}
    /// </summary>
    public sealed partial class KeyAssignment
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
        /// Hash of the assigned API key<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
        /// </summary>
        /// <example>c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyHash { get; set; }

        /// <summary>
        /// Label of the API key<br/>
        /// Example: prod-key
        /// </summary>
        /// <example>prod-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyLabel { get; set; }

        /// <summary>
        /// Name of the API key<br/>
        /// Example: Production Key
        /// </summary>
        /// <example>Production Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyAssignment" /> class.
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
        /// <param name="keyHash">
        /// Hash of the assigned API key<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
        /// </param>
        /// <param name="keyLabel">
        /// Label of the API key<br/>
        /// Example: prod-key
        /// </param>
        /// <param name="keyName">
        /// Name of the API key<br/>
        /// Example: Production Key
        /// </param>
        /// <param name="assignedBy">
        /// User ID of who made the assignment<br/>
        /// Example: user_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyAssignment(
            string createdAt,
            global::System.Guid guardrailId,
            global::System.Guid id,
            string keyHash,
            string keyLabel,
            string keyName,
            string? assignedBy)
        {
            this.AssignedBy = assignedBy;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.GuardrailId = guardrailId;
            this.Id = id;
            this.KeyHash = keyHash ?? throw new global::System.ArgumentNullException(nameof(keyHash));
            this.KeyLabel = keyLabel ?? throw new global::System.ArgumentNullException(nameof(keyLabel));
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyAssignment" /> class.
        /// </summary>
        public KeyAssignment()
        {
        }

    }
}