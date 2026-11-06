
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelAvailabilityGuardrailPolicy
    {
        /// <summary>
        /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
        /// </summary>
        /// <example>{"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModelAvailabilityPolicyConfig Config { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelAvailabilityGuardrailPolicyPolicyTypeJsonConverter))]
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyPolicyType PolicyType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAvailabilityGuardrailPolicy" /> class.
        /// </summary>
        /// <param name="config">
        /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
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
        public ModelAvailabilityGuardrailPolicy(
            global::OpenRouter.GuardrailModelAvailabilityPolicyConfig config,
            global::System.Guid id,
            string name,
            global::OpenRouter.ModelAvailabilityGuardrailPolicyPolicyType policyType)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PolicyType = policyType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAvailabilityGuardrailPolicy" /> class.
        /// </summary>
        public ModelAvailabilityGuardrailPolicy()
        {
        }

    }
}