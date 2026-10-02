
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"created_at":"2025-08-24T10:30:00Z","id":"770e8400-e29b-41d4-a716-446655440000","limit_usd":100,"reset_interval":"monthly","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}],"include_byok_in_budgets":false}
    /// </summary>
    public sealed partial class ListWorkspaceBudgetsResponse
    {
        /// <summary>
        /// List of budgets configured for the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget> Data { get; set; }

        /// <summary>
        /// Whether BYOK (bring-your-own-key) spend is included when enforcing the workspace's budgets. This is a workspace-wide setting that applies to all budget intervals (daily, weekly, monthly, and lifetime).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        public bool? IncludeByokInBudgets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceBudgetsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of budgets configured for the workspace
        /// </param>
        /// <param name="includeByokInBudgets">
        /// Whether BYOK (bring-your-own-key) spend is included when enforcing the workspace's budgets. This is a workspace-wide setting that applies to all budget intervals (daily, weekly, monthly, and lifetime).<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkspaceBudgetsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget> data,
            bool? includeByokInBudgets)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.IncludeByokInBudgets = includeByokInBudgets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceBudgetsResponse" /> class.
        /// </summary>
        public ListWorkspaceBudgetsResponse()
        {
        }

    }
}