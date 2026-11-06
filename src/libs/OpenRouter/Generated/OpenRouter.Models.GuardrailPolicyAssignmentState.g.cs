
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailPolicyAssignmentState
    {
        /// <summary>
        /// Whether the subject is opted out of the workspace default<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OptedOut { get; set; }

        /// <summary>
        /// Policies of this type assigned directly to the subject<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> PolicyIds { get; set; }

        /// <summary>
        /// Workspace default policies of this type the subject inherits<br/>
        /// Example: [2c6f1a4e-0b7d-4e59-9a61-3f8d2e7c1b90]
        /// </summary>
        /// <example>[2c6f1a4e-0b7d-4e59-9a61-3f8d2e7c1b90]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_default_policy_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> WorkspaceDefaultPolicyIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPolicyAssignmentState" /> class.
        /// </summary>
        /// <param name="optedOut">
        /// Whether the subject is opted out of the workspace default<br/>
        /// Example: false
        /// </param>
        /// <param name="policyIds">
        /// Policies of this type assigned directly to the subject<br/>
        /// Example: []
        /// </param>
        /// <param name="workspaceDefaultPolicyIds">
        /// Workspace default policies of this type the subject inherits<br/>
        /// Example: [2c6f1a4e-0b7d-4e59-9a61-3f8d2e7c1b90]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailPolicyAssignmentState(
            bool optedOut,
            global::System.Collections.Generic.IList<global::System.Guid> policyIds,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceDefaultPolicyIds)
        {
            this.OptedOut = optedOut;
            this.PolicyIds = policyIds ?? throw new global::System.ArgumentNullException(nameof(policyIds));
            this.WorkspaceDefaultPolicyIds = workspaceDefaultPolicyIds ?? throw new global::System.ArgumentNullException(nameof(workspaceDefaultPolicyIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPolicyAssignmentState" /> class.
        /// </summary>
        public GuardrailPolicyAssignmentState()
        {
        }

    }
}