
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceBudget
    {
        /// <summary>
        /// ISO 8601 timestamp of when the budget was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the budget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Spending limit in USD for this interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitUsd { get; set; }

        /// <summary>
        /// Interval at which spend resets. Null means a lifetime (one-time) budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WorkspaceBudgetResetIntervalJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.WorkspaceBudgetResetInterval ResetInterval { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the budget was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// ID of the workspace the budget belongs to
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
        /// Initializes a new instance of the <see cref="WorkspaceBudget" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the budget was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the budget
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD for this interval
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which spend resets. Null means a lifetime (one-time) budget.
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the budget was last updated
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace the budget belongs to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceBudget(
            string createdAt,
            global::System.Guid id,
            double limitUsd,
            global::OpenRouter.WorkspaceBudgetResetInterval resetInterval,
            string updatedAt,
            global::System.Guid workspaceId)
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