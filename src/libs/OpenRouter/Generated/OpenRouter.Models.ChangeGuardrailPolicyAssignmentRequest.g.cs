
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChangeGuardrailPolicyAssignmentRequest
    {
        /// <summary>
        /// `true` assigns the policy to the subject, `false` removes it<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Assigned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_assignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.GuardrailPolicyAssignmentState, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.GuardrailPolicyAssignmentState, object> ExpectedAssignment { get; set; }

        /// <summary>
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PolicyId { get; set; }

        /// <summary>
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </summary>
        /// <example>budget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChangeGuardrailPolicyAssignmentRequestPolicyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChangeGuardrailPolicyAssignmentRequestPolicyType PolicyType { get; set; }

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
        /// Initializes a new instance of the <see cref="ChangeGuardrailPolicyAssignmentRequest" /> class.
        /// </summary>
        /// <param name="assigned">
        /// `true` assigns the policy to the subject, `false` removes it<br/>
        /// Example: true
        /// </param>
        /// <param name="expectedAssignment"></param>
        /// <param name="policyId">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="policyType">
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChangeGuardrailPolicyAssignmentRequest(
            bool assigned,
            global::OpenRouter.AllOf<global::OpenRouter.GuardrailPolicyAssignmentState, object> expectedAssignment,
            global::System.Guid policyId,
            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequestPolicyType policyType,
            global::System.Guid? workspaceId)
        {
            this.Assigned = assigned;
            this.ExpectedAssignment = expectedAssignment;
            this.PolicyId = policyId;
            this.PolicyType = policyType;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGuardrailPolicyAssignmentRequest" /> class.
        /// </summary>
        public ChangeGuardrailPolicyAssignmentRequest()
        {
        }

    }
}