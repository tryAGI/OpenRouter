
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One budget layer that applies to requests made with this key, with the spend enforcement compares against it.<br/>
    /// Example: {"budget_id":null,"guardrail_id":"0df9e665-d932-5740-b2c7-b52af166bc11","include_byok":false,"limit_usd":50,"remaining_usd":17.5,"reset_interval":"weekly","resets_at":"2026-10-12T00:00:00.000Z","scope":"member","spend_usd":32.5}
    /// </summary>
    public sealed partial class KeyBudget
    {
        /// <summary>
        /// ID of the workspace budget for the `workspace` scope; null for other scopes.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// ID of the guardrail that carries this budget; null for other scopes.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        public string? GuardrailId { get; set; }

        /// <summary>
        /// Whether external BYOK inference spend counts toward this budget.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByok { get; set; }

        /// <summary>
        /// Budget limit in USD for the current window.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitUsd { get; set; }

        /// <summary>
        /// `limit_usd - spend_usd`. Zero or negative means this layer rejects requests with a 403 until it resets.<br/>
        /// Example: 17.5F
        /// </summary>
        /// <example>17.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingUsd { get; set; }

        /// <summary>
        /// UTC window the spend is counted over (weeks start Monday); null for a lifetime budget that never resets.<br/>
        /// Example: weekly
        /// </summary>
        /// <example>weekly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.KeyBudgetResetIntervalJsonConverter))]
        public global::OpenRouter.KeyBudgetResetInterval? ResetInterval { get; set; }

        /// <summary>
        /// ISO 8601 UTC instant at which the window rolls over and spend returns to zero; null for a lifetime budget.<br/>
        /// Example: 2026-10-12T00:00:00.000Z
        /// </summary>
        /// <example>2026-10-12T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resets_at")]
        public global::System.DateTime? ResetsAt { get; set; }

        /// <summary>
        /// Which budget layer this is, in the order enforcement checks them: the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).<br/>
        /// Example: member
        /// </summary>
        /// <example>member</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.KeyBudgetScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.KeyBudgetScope Scope { get; set; }

        /// <summary>
        /// Spend in USD that enforcement counts against this limit in the current window: the member aggregate for member-scoped layers, otherwise this key or workspace.<br/>
        /// Example: 32.5F
        /// </summary>
        /// <example>32.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SpendUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyBudget" /> class.
        /// </summary>
        /// <param name="includeByok">
        /// Whether external BYOK inference spend counts toward this budget.<br/>
        /// Example: false
        /// </param>
        /// <param name="limitUsd">
        /// Budget limit in USD for the current window.<br/>
        /// Example: 50
        /// </param>
        /// <param name="remainingUsd">
        /// `limit_usd - spend_usd`. Zero or negative means this layer rejects requests with a 403 until it resets.<br/>
        /// Example: 17.5F
        /// </param>
        /// <param name="scope">
        /// Which budget layer this is, in the order enforcement checks them: the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).<br/>
        /// Example: member
        /// </param>
        /// <param name="spendUsd">
        /// Spend in USD that enforcement counts against this limit in the current window: the member aggregate for member-scoped layers, otherwise this key or workspace.<br/>
        /// Example: 32.5F
        /// </param>
        /// <param name="budgetId">
        /// ID of the workspace budget for the `workspace` scope; null for other scopes.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="guardrailId">
        /// ID of the guardrail that carries this budget; null for other scopes.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="resetInterval">
        /// UTC window the spend is counted over (weeks start Monday); null for a lifetime budget that never resets.<br/>
        /// Example: weekly
        /// </param>
        /// <param name="resetsAt">
        /// ISO 8601 UTC instant at which the window rolls over and spend returns to zero; null for a lifetime budget.<br/>
        /// Example: 2026-10-12T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyBudget(
            bool includeByok,
            double limitUsd,
            double remainingUsd,
            global::OpenRouter.KeyBudgetScope scope,
            double spendUsd,
            string? budgetId,
            string? guardrailId,
            global::OpenRouter.KeyBudgetResetInterval? resetInterval,
            global::System.DateTime? resetsAt)
        {
            this.BudgetId = budgetId;
            this.GuardrailId = guardrailId;
            this.IncludeByok = includeByok;
            this.LimitUsd = limitUsd;
            this.RemainingUsd = remainingUsd;
            this.ResetInterval = resetInterval;
            this.ResetsAt = resetsAt;
            this.Scope = scope;
            this.SpendUsd = spendUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyBudget" /> class.
        /// </summary>
        public KeyBudget()
        {
        }

    }
}