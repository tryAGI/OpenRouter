
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BudgetAccountGuardrailPolicy
    {
        /// <summary>
        /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
        /// </summary>
        /// <example>{"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailBudgetPolicyConfig Config { get; set; }

        /// <summary>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Kept in sync with a v1 guardrail; saving changes creates an account copy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_synced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSynced { get; set; }

        /// <summary>
        /// Synced from a v1 workspace default guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_workspace_default_synced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsWorkspaceDefaultSynced { get; set; }

        /// <summary>
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </summary>
        /// <example>Engineering monthly budget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </summary>
        /// <example>[0df9e665-d932-5740-b2c7-b52af166bc11]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_workspace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> OptedOutWorkspaceIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BudgetAccountGuardrailPolicyPolicyTypeJsonConverter))]
        public global::OpenRouter.BudgetAccountGuardrailPolicyPolicyType PolicyType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceCount { get; set; }

        /// <summary>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </summary>
        /// <example>[0df9e665-d932-5740-b2c7-b52af166bc11]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> WorkspaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetAccountGuardrailPolicy" /> class.
        /// </summary>
        /// <param name="config">
        /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
        /// </param>
        /// <param name="createdAt">
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="isDefault"></param>
        /// <param name="isSynced">
        /// Kept in sync with a v1 guardrail; saving changes creates an account copy
        /// </param>
        /// <param name="isWorkspaceDefaultSynced">
        /// Synced from a v1 workspace default guardrail
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="optedOutWorkspaceIds">
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </param>
        /// <param name="workspaceCount"></param>
        /// <param name="workspaceIds">
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BudgetAccountGuardrailPolicy(
            global::OpenRouter.GuardrailBudgetPolicyConfig config,
            string createdAt,
            global::System.Guid id,
            bool isDefault,
            bool isSynced,
            bool isWorkspaceDefaultSynced,
            string name,
            global::System.Collections.Generic.IList<global::System.Guid> optedOutWorkspaceIds,
            int workspaceCount,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds,
            global::OpenRouter.BudgetAccountGuardrailPolicyPolicyType policyType,
            string? updatedAt)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id;
            this.IsDefault = isDefault;
            this.IsSynced = isSynced;
            this.IsWorkspaceDefaultSynced = isWorkspaceDefaultSynced;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OptedOutWorkspaceIds = optedOutWorkspaceIds ?? throw new global::System.ArgumentNullException(nameof(optedOutWorkspaceIds));
            this.PolicyType = policyType;
            this.UpdatedAt = updatedAt;
            this.WorkspaceCount = workspaceCount;
            this.WorkspaceIds = workspaceIds ?? throw new global::System.ArgumentNullException(nameof(workspaceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetAccountGuardrailPolicy" /> class.
        /// </summary>
        public BudgetAccountGuardrailPolicy()
        {
        }

    }
}