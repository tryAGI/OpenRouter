
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModerationGuardrailPolicySummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ApiKeyCount { get; set; }

        /// <summary>
        /// Example: {"content_filter_builtins":[{"action":"block","slug":"secrets"}]}
        /// </summary>
        /// <example>{"content_filter_builtins":[{"action":"block","slug":"secrets"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModerationPolicyConfig Config { get; set; }

        /// <summary>
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether the policy is kept in sync with a v1 guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_legacy_mapped")]
        public bool? IsLegacyMapped { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_workspace_default")]
        public bool? IsWorkspaceDefault { get; set; }

        /// <summary>
        /// IDs of the v1 guardrails this policy was migrated from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_guardrail_ids")]
        public global::System.Collections.Generic.IList<string>? LegacyGuardrailIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemberCount { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModerationGuardrailPolicySummaryPolicyTypeJsonConverter))]
        public global::OpenRouter.ModerationGuardrailPolicySummaryPolicyType PolicyType { get; set; }

        /// <summary>
        /// IDs of the v1 guardrails this policy replaced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaced_legacy_guardrail_ids")]
        public global::System.Collections.Generic.IList<string>? ReplacedLegacyGuardrailIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailPolicySummary" /> class.
        /// </summary>
        /// <param name="apiKeyCount"></param>
        /// <param name="config">
        /// Example: {"content_filter_builtins":[{"action":"block","slug":"secrets"}]}
        /// </param>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="memberCount"></param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="isLegacyMapped">
        /// Whether the policy is kept in sync with a v1 guardrail
        /// </param>
        /// <param name="isWorkspaceDefault"></param>
        /// <param name="legacyGuardrailIds">
        /// IDs of the v1 guardrails this policy was migrated from
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="replacedLegacyGuardrailIds">
        /// IDs of the v1 guardrails this policy replaced
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationGuardrailPolicySummary(
            int apiKeyCount,
            global::OpenRouter.GuardrailModerationPolicyConfig config,
            global::System.Guid id,
            int memberCount,
            string name,
            bool? isLegacyMapped,
            bool? isWorkspaceDefault,
            global::System.Collections.Generic.IList<string>? legacyGuardrailIds,
            global::OpenRouter.ModerationGuardrailPolicySummaryPolicyType policyType,
            global::System.Collections.Generic.IList<string>? replacedLegacyGuardrailIds,
            string? updatedAt)
        {
            this.ApiKeyCount = apiKeyCount;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Id = id;
            this.IsLegacyMapped = isLegacyMapped;
            this.IsWorkspaceDefault = isWorkspaceDefault;
            this.LegacyGuardrailIds = legacyGuardrailIds;
            this.MemberCount = memberCount;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PolicyType = policyType;
            this.ReplacedLegacyGuardrailIds = replacedLegacyGuardrailIds;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailPolicySummary" /> class.
        /// </summary>
        public ModerationGuardrailPolicySummary()
        {
        }

    }
}