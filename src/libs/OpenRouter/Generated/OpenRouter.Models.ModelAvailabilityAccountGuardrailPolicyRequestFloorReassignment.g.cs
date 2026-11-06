
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Move workspaces off this policy onto another workspace-wide policy in the same write
    /// </summary>
    public sealed partial class ModelAvailabilityAccountGuardrailPolicyRequestFloorReassignment
    {
        /// <summary>
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PolicyId { get; set; }

        /// <summary>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </summary>
        /// <example>[0df9e665-d932-5740-b2c7-b52af166bc11]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> WorkspaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAvailabilityAccountGuardrailPolicyRequestFloorReassignment" /> class.
        /// </summary>
        /// <param name="policyId">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="workspaceIds">
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAvailabilityAccountGuardrailPolicyRequestFloorReassignment(
            global::System.Guid policyId,
            global::System.Collections.Generic.IList<global::System.Guid> workspaceIds)
        {
            this.PolicyId = policyId;
            this.WorkspaceIds = workspaceIds ?? throw new global::System.ArgumentNullException(nameof(workspaceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAvailabilityAccountGuardrailPolicyRequestFloorReassignment" /> class.
        /// </summary>
        public ModelAvailabilityAccountGuardrailPolicyRequestFloorReassignment()
        {
        }

    }
}