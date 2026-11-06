
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BudgetGuardrailPolicy
    {
        /// <summary>
        /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
        /// </summary>
        /// <example>{"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailBudgetPolicyConfig Config { get; set; }

        /// <summary>
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </summary>
        /// <example>Engineering monthly budget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BudgetGuardrailPolicyPolicyTypeJsonConverter))]
        public global::OpenRouter.BudgetGuardrailPolicyPolicyType PolicyType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGuardrailPolicy" /> class.
        /// </summary>
        /// <param name="config">
        /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
        /// </param>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="policyType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BudgetGuardrailPolicy(
            global::OpenRouter.GuardrailBudgetPolicyConfig config,
            global::System.Guid id,
            string name,
            global::OpenRouter.BudgetGuardrailPolicyPolicyType policyType)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PolicyType = policyType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGuardrailPolicy" /> class.
        /// </summary>
        public BudgetGuardrailPolicy()
        {
        }

    }
}