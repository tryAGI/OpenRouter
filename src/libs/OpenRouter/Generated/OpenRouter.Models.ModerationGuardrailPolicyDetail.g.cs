
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModerationGuardrailPolicyDetail
    {
        /// <summary>
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ApiKeyHashes { get; set; }

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
        /// Whether this is an account-owned policy rather than a workspace policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_account_policy")]
        public bool? IsAccountPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_workspace_default")]
        public bool? IsWorkspaceDefault { get; set; }

        /// <summary>
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </summary>
        /// <example>[user_2abcDEFghiJKLmnoPQRstu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MemberIds { get; set; }

        /// <summary>
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </summary>
        /// <example>Engineering monthly budget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_api_key_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OptedOutApiKeyHashes { get; set; }

        /// <summary>
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </summary>
        /// <example>[user_2abcDEFghiJKLmnoPQRstu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_member_ids")]
        public global::System.Collections.Generic.IList<string>? OptedOutMemberIds { get; set; }

        /// <summary>
        /// API keys that have a different policy of this type assigned directly<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overridden_api_key_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OverriddenApiKeyHashes { get; set; }

        /// <summary>
        /// Members that have a different policy of this type assigned directly<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </summary>
        /// <example>[user_2abcDEFghiJKLmnoPQRstu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overridden_member_ids")]
        public global::System.Collections.Generic.IList<string>? OverriddenMemberIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModerationGuardrailPolicyDetailPolicyTypeJsonConverter))]
        public global::OpenRouter.ModerationGuardrailPolicyDetailPolicyType PolicyType { get; set; }

        /// <summary>
        /// `legacy_mapping` when the policy is synced from a v1 guardrail, `account_default` when it is an account-wide default, otherwise `null`<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModerationGuardrailPolicyDetailReferenceJsonConverter))]
        public global::OpenRouter.ModerationGuardrailPolicyDetailReference? Reference { get; set; }

        /// <summary>
        /// Whether this workspace copy replaced a v1 workspace default guardrail that still exists; it cannot be deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaces_legacy_default")]
        public bool? ReplacesLegacyDefault { get; set; }

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
        /// Initializes a new instance of the <see cref="ModerationGuardrailPolicyDetail" /> class.
        /// </summary>
        /// <param name="apiKeyHashes">
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="config">
        /// Example: {"content_filter_builtins":[{"action":"block","slug":"secrets"}]}
        /// </param>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="memberIds">
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="optedOutApiKeyHashes">
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="overriddenApiKeyHashes">
        /// API keys that have a different policy of this type assigned directly<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="isAccountPolicy">
        /// Whether this is an account-owned policy rather than a workspace policy
        /// </param>
        /// <param name="isWorkspaceDefault"></param>
        /// <param name="optedOutMemberIds">
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="overriddenMemberIds">
        /// Members that have a different policy of this type assigned directly<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="reference">
        /// `legacy_mapping` when the policy is synced from a v1 guardrail, `account_default` when it is an account-wide default, otherwise `null`<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replacesLegacyDefault">
        /// Whether this workspace copy replaced a v1 workspace default guardrail that still exists; it cannot be deleted
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationGuardrailPolicyDetail(
            global::System.Collections.Generic.IList<string> apiKeyHashes,
            global::OpenRouter.GuardrailModerationPolicyConfig config,
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> memberIds,
            string name,
            global::System.Collections.Generic.IList<string> optedOutApiKeyHashes,
            global::System.Collections.Generic.IList<string> overriddenApiKeyHashes,
            bool? isAccountPolicy,
            bool? isWorkspaceDefault,
            global::System.Collections.Generic.IList<string>? optedOutMemberIds,
            global::System.Collections.Generic.IList<string>? overriddenMemberIds,
            global::OpenRouter.ModerationGuardrailPolicyDetailPolicyType policyType,
            global::OpenRouter.ModerationGuardrailPolicyDetailReference? reference,
            bool? replacesLegacyDefault,
            string? updatedAt)
        {
            this.ApiKeyHashes = apiKeyHashes ?? throw new global::System.ArgumentNullException(nameof(apiKeyHashes));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Id = id;
            this.IsAccountPolicy = isAccountPolicy;
            this.IsWorkspaceDefault = isWorkspaceDefault;
            this.MemberIds = memberIds ?? throw new global::System.ArgumentNullException(nameof(memberIds));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OptedOutApiKeyHashes = optedOutApiKeyHashes ?? throw new global::System.ArgumentNullException(nameof(optedOutApiKeyHashes));
            this.OptedOutMemberIds = optedOutMemberIds;
            this.OverriddenApiKeyHashes = overriddenApiKeyHashes ?? throw new global::System.ArgumentNullException(nameof(overriddenApiKeyHashes));
            this.OverriddenMemberIds = overriddenMemberIds;
            this.PolicyType = policyType;
            this.Reference = reference;
            this.ReplacesLegacyDefault = replacesLegacyDefault;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationGuardrailPolicyDetail" /> class.
        /// </summary>
        public ModerationGuardrailPolicyDetail()
        {
        }

    }
}