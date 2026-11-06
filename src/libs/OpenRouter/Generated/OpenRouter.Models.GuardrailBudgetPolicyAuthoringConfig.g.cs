
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
    /// </summary>
    public sealed partial class GuardrailBudgetPolicyAuthoringConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInBudgets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailBudgetPolicyAuthoringConfigResetIntervalJsonConverter))]
        public global::OpenRouter.GuardrailBudgetPolicyAuthoringConfigResetInterval? ResetInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBudgetPolicyAuthoringConfig" /> class.
        /// </summary>
        /// <param name="includeByokInBudgets"></param>
        /// <param name="limitUsd"></param>
        /// <param name="resetInterval"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailBudgetPolicyAuthoringConfig(
            bool includeByokInBudgets,
            double? limitUsd,
            global::OpenRouter.GuardrailBudgetPolicyAuthoringConfigResetInterval? resetInterval)
        {
            this.IncludeByokInBudgets = includeByokInBudgets;
            this.LimitUsd = limitUsd;
            this.ResetInterval = resetInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBudgetPolicyAuthoringConfig" /> class.
        /// </summary>
        public GuardrailBudgetPolicyAuthoringConfig()
        {
        }

    }
}