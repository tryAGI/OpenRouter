
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateModelAvailabilityGuardrailPolicyRequest
    {
        /// <summary>
        /// Complete new list of assigned API keys. Send together with `member_ids`, or omit both to keep the stored assignments.<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyHashes { get; set; }

        /// <summary>
        /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
        /// </summary>
        /// <example>{"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModelAvailabilityPolicyAuthoringConfig Config { get; set; }

        /// <summary>
        /// Omit to keep the stored default status; `false` unsets the policy as the workspace default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_workspace_default")]
        public bool? IsWorkspaceDefault { get; set; }

        /// <summary>
        /// Complete new list of assigned members. Send together with `api_key_hashes`, or omit both to keep the stored assignments.<br/>
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
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? OptedOutApiKeyHashes { get; set; }

        /// <summary>
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </summary>
        /// <example>[user_2abcDEFghiJKLmnoPQRstu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_member_ids")]
        public global::System.Collections.Generic.IList<string>? OptedOutMemberIds { get; set; }

        /// <summary>
        /// Workspace the policy belongs to<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelAvailabilityGuardrailPolicyRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="apiKeyHashes">
        /// Complete new list of assigned API keys. Send together with `member_ids`, or omit both to keep the stored assignments.<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="isWorkspaceDefault">
        /// Omit to keep the stored default status; `false` unsets the policy as the workspace default.
        /// </param>
        /// <param name="memberIds">
        /// Complete new list of assigned members. Send together with `api_key_hashes`, or omit both to keep the stored assignments.<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="optedOutApiKeyHashes">
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="optedOutMemberIds">
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateModelAvailabilityGuardrailPolicyRequest(
            global::OpenRouter.GuardrailModelAvailabilityPolicyAuthoringConfig config,
            string name,
            global::System.Guid workspaceId,
            global::System.Collections.Generic.IList<string>? apiKeyHashes,
            bool? isWorkspaceDefault,
            global::System.Collections.Generic.IList<string>? memberIds,
            global::System.Collections.Generic.IList<string>? optedOutApiKeyHashes,
            global::System.Collections.Generic.IList<string>? optedOutMemberIds)
        {
            this.ApiKeyHashes = apiKeyHashes;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.IsWorkspaceDefault = isWorkspaceDefault;
            this.MemberIds = memberIds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OptedOutApiKeyHashes = optedOutApiKeyHashes;
            this.OptedOutMemberIds = optedOutMemberIds;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelAvailabilityGuardrailPolicyRequest" /> class.
        /// </summary>
        public UpdateModelAvailabilityGuardrailPolicyRequest()
        {
        }

    }
}