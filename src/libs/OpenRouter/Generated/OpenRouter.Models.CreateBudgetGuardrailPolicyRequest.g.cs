
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBudgetGuardrailPolicyRequest
    {
        /// <summary>
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
        /// </summary>
        /// <example>{"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailBudgetPolicyAuthoringConfig Config { get; set; }

        /// <summary>
        /// Make this the workspace default for its policy type. Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_workspace_default")]
        public bool? IsWorkspaceDefault { get; set; }

        /// <summary>
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </summary>
        /// <example>[user_2abcDEFghiJKLmnoPQRstu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_ids")]
        public global::System.Collections.Generic.IList<string>? MemberIds { get; set; }

        /// <summary>
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </summary>
        /// <example>Engineering monthly budget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// API keys that should not inherit the policy when it is the workspace default<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? OptedOutApiKeyHashes { get; set; }

        /// <summary>
        /// Members that should not inherit the policy when it is the workspace default<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </summary>
        /// <example>[user_2abcDEFghiJKLmnoPQRstu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_member_ids")]
        public global::System.Collections.Generic.IList<string>? OptedOutMemberIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateBudgetGuardrailPolicyRequestPolicyTypeJsonConverter))]
        public global::OpenRouter.CreateBudgetGuardrailPolicyRequestPolicyType PolicyType { get; set; }

        /// <summary>
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBudgetGuardrailPolicyRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Example: {"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"}
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="apiKeyHashes">
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="isWorkspaceDefault">
        /// Make this the workspace default for its policy type. Defaults to `false`.
        /// </param>
        /// <param name="memberIds">
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="optedOutApiKeyHashes">
        /// API keys that should not inherit the policy when it is the workspace default<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="optedOutMemberIds">
        /// Members that should not inherit the policy when it is the workspace default<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBudgetGuardrailPolicyRequest(
            global::OpenRouter.GuardrailBudgetPolicyAuthoringConfig config,
            string name,
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            bool? isWorkspaceDefault,
            global::System.Collections.Generic.IList<string>? memberIds,
            global::System.Collections.Generic.IList<string>? optedOutApiKeyHashes,
            global::System.Collections.Generic.IList<string>? optedOutMemberIds,
            global::OpenRouter.CreateBudgetGuardrailPolicyRequestPolicyType policyType,
            global::System.Guid? workspaceId)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.IsWorkspaceDefault = isWorkspaceDefault;
            this.MemberIds = memberIds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OptedOutApiKeyHashes = optedOutApiKeyHashes;
            this.OptedOutMemberIds = optedOutMemberIds;
            this.PolicyType = policyType;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBudgetGuardrailPolicyRequest" /> class.
        /// </summary>
        public CreateBudgetGuardrailPolicyRequest()
        {
        }

    }
}