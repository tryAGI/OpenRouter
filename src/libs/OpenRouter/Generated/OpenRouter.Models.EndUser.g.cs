
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"created_at":"2026-09-16T12:00:00Z","is_active":true,"updated_at":"2026-09-16T12:00:00Z","user":"employee_123"}
    /// </summary>
    public sealed partial class EndUser
    {
        /// <summary>
        /// Registration creation time.<br/>
        /// Example: 2026-09-16T12:00:00Z
        /// </summary>
        /// <example>2026-09-16T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether this registration is active. Not an inference authorization decision.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Last registration lifecycle update time.<br/>
        /// Example: 2026-09-16T12:00:00Z
        /// </summary>
        /// <example>2026-09-16T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Immutable case-sensitive tracking string supplied as user on inference requests or as external.user on API keys: 1 to 512 characters, well-formed Unicode, no NUL, no surrounding whitespace. URL-encode it in resource paths; an ID of `.` or `..` cannot be addressed by path, so look it up with the list filter.<br/>
        /// Example: employee_123
        /// </summary>
        /// <example>employee_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUser" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Registration creation time.<br/>
        /// Example: 2026-09-16T12:00:00Z
        /// </param>
        /// <param name="isActive">
        /// Whether this registration is active. Not an inference authorization decision.<br/>
        /// Example: true
        /// </param>
        /// <param name="updatedAt">
        /// Last registration lifecycle update time.<br/>
        /// Example: 2026-09-16T12:00:00Z
        /// </param>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests or as external.user on API keys: 1 to 512 characters, well-formed Unicode, no NUL, no surrounding whitespace. URL-encode it in resource paths; an ID of `.` or `..` cannot be addressed by path, so look it up with the list filter.<br/>
        /// Example: employee_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUser(
            global::System.DateTime createdAt,
            bool isActive,
            global::System.DateTime updatedAt,
            string user)
        {
            this.CreatedAt = createdAt;
            this.IsActive = isActive;
            this.UpdatedAt = updatedAt;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUser" /> class.
        /// </summary>
        public EndUser()
        {
        }

    }
}