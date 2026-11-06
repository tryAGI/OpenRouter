
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountGuardrailPolicyDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AccountGuardrailPolicyDiscriminatorPolicyTypeJsonConverter))]
        public global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType? PolicyType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGuardrailPolicyDiscriminator" /> class.
        /// </summary>
        /// <param name="policyType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGuardrailPolicyDiscriminator(
            global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType? policyType)
        {
            this.PolicyType = policyType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGuardrailPolicyDiscriminator" /> class.
        /// </summary>
        public AccountGuardrailPolicyDiscriminator()
        {
        }

    }
}