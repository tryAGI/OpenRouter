
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"created_at":"2025-08-24T10:30:00Z","id":"770e8400-e29b-41d4-a716-446655440000","limit_usd":100,"reset_interval":"monthly","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    public sealed partial class WorkspaceBudget
    {
        /// <summary>
        /// ISO 8601 timestamp of when the budget was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the budget<br/>
        /// Example: 770e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>770e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Spending limit in USD for this interval<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitUsd { get; set; }

        /// <summary>
        /// Interval at which spend resets. Null means a lifetime (one-time) budget.<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WorkspaceBudgetResetIntervalJsonConverter))]
        public global::OpenRouter.WorkspaceBudgetResetInterval? ResetInterval { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the budget was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </summary>
        /// <example>2025-08-24T15:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// ID of the workspace the budget belongs to<br/>
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
        /// Initializes a new instance of the <see cref="WorkspaceBudget" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the budget was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="id">
        /// Unique identifier for the budget<br/>
        /// Example: 770e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD for this interval<br/>
        /// Example: 100
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the budget was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace the budget belongs to<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which spend resets. Null means a lifetime (one-time) budget.<br/>
        /// Example: monthly
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceBudget(
            string createdAt,
            global::System.Guid id,
            double limitUsd,
            string updatedAt,
            global::System.Guid workspaceId,
            global::OpenRouter.WorkspaceBudgetResetInterval? resetInterval)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id;
            this.LimitUsd = limitUsd;
            this.ResetInterval = resetInterval;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceBudget" /> class.
        /// </summary>
        public WorkspaceBudget()
        {
        }

    }
}