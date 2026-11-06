
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
    /// </summary>
    public sealed partial class GuardrailBudgetPolicyConfig
    {
        /// <summary>
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend. Defaults to false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        public bool? IncludeByokInBudgets { get; set; }

        /// <summary>
        /// Spending limit in USD. Must be provided together with `reset_interval`: a request that sets only one of the two is rejected with a 400.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter))]
        public global::OpenRouter.GuardrailInterval? ResetInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBudgetPolicyConfig" /> class.
        /// </summary>
        /// <param name="includeByokInBudgets">
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend. Defaults to false.<br/>
        /// Example: false
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD. Must be provided together with `reset_interval`: a request that sets only one of the two is rejected with a 400.<br/>
        /// Example: 50
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailBudgetPolicyConfig(
            bool? includeByokInBudgets,
            double? limitUsd,
            global::OpenRouter.GuardrailInterval? resetInterval)
        {
            this.IncludeByokInBudgets = includeByokInBudgets;
            this.LimitUsd = limitUsd;
            this.ResetInterval = resetInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBudgetPolicyConfig" /> class.
        /// </summary>
        public GuardrailBudgetPolicyConfig()
        {
        }

    }
}