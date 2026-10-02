
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"include_byok_in_budgets":true,"limit_usd":100}
    /// </summary>
    public sealed partial class UpsertWorkspaceBudgetRequest
    {
        /// <summary>
        /// Whether to include BYOK (bring-your-own-key) spend when enforcing the workspace's budgets. This is a workspace-wide setting: it applies to every budget interval (daily, weekly, monthly, and lifetime), not just the interval being upserted in this request. Omit to leave the current setting unchanged.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        public bool? IncludeByokInBudgets { get; set; }

        /// <summary>
        /// Spending limit in USD. Must be greater than 0.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertWorkspaceBudgetRequest" /> class.
        /// </summary>
        /// <param name="limitUsd">
        /// Spending limit in USD. Must be greater than 0.<br/>
        /// Example: 100
        /// </param>
        /// <param name="includeByokInBudgets">
        /// Whether to include BYOK (bring-your-own-key) spend when enforcing the workspace's budgets. This is a workspace-wide setting: it applies to every budget interval (daily, weekly, monthly, and lifetime), not just the interval being upserted in this request. Omit to leave the current setting unchanged.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertWorkspaceBudgetRequest(
            double limitUsd,
            bool? includeByokInBudgets)
        {
            this.IncludeByokInBudgets = includeByokInBudgets;
            this.LimitUsd = limitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertWorkspaceBudgetRequest" /> class.
        /// </summary>
        public UpsertWorkspaceBudgetRequest()
        {
        }

    }
}