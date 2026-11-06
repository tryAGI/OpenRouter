
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"config":{"content_filter_builtins":[{"action":"block","slug":"secrets"}]},"name":"Block secrets","policy_type":"moderation","workspace_ids":["0df9e665-d932-5740-b2c7-b52af166bc11"]}
    /// </summary>
    public sealed partial class ModerationAccountGuardrailPolicyRequest
    {
        /// <summary>
        /// Example: {"content_filter_builtins":[{"action":"block","slug":"secrets"}]}
        /// </summary>
        /// <example>{"content_filter_builtins":[{"action":"block","slug":"secrets"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModerationPolicyConfig Config { get; set; }

        /// <summary>
        /// Move workspaces off this policy onto another workspace-wide policy in the same write
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("floor_reassignment")]
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequestFloorReassignment? FloorReassignment { get; set; }

        /// <summary>
        /// Cover every workspace in the account except `opted_out_workspace_ids`. On update, `false` on the current default unsets it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Keep workspaces that inherited the replaced default on that policy. Cannot be combined with `released_floor_workspace_ids`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_previous_default_workspaces")]
        public bool? KeepPreviousDefaultWorkspaces { get; set; }

        /// <summary>
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </summary>
        /// <example>Engineering monthly budget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Workspaces left out of a default policy<br/>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </summary>
        /// <example>[0df9e665-d932-5740-b2c7-b52af166bc11]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out_workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? OptedOutWorkspaceIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModerationAccountGuardrailPolicyRequestPolicyTypeJsonConverter))]
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequestPolicyType PolicyType { get; set; }

        /// <summary>
        /// Workspaces whose own workspace-wide policy of this type is dropped so they inherit this default<br/>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </summary>
        /// <example>[0df9e665-d932-5740-b2c7-b52af166bc11]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("released_floor_workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReleasedFloorWorkspaceIds { get; set; }

        /// <summary>
        /// Workspaces the policy covers when it is not the default<br/>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </summary>
        /// <example>[0df9e665-d932-5740-b2c7-b52af166bc11]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? WorkspaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationAccountGuardrailPolicyRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Example: {"content_filter_builtins":[{"action":"block","slug":"secrets"}]}
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="floorReassignment">
        /// Move workspaces off this policy onto another workspace-wide policy in the same write
        /// </param>
        /// <param name="isDefault">
        /// Cover every workspace in the account except `opted_out_workspace_ids`. On update, `false` on the current default unsets it.
        /// </param>
        /// <param name="keepPreviousDefaultWorkspaces">
        /// Keep workspaces that inherited the replaced default on that policy. Cannot be combined with `released_floor_workspace_ids`.
        /// </param>
        /// <param name="optedOutWorkspaceIds">
        /// Workspaces left out of a default policy<br/>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="releasedFloorWorkspaceIds">
        /// Workspaces whose own workspace-wide policy of this type is dropped so they inherit this default<br/>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </param>
        /// <param name="workspaceIds">
        /// Workspaces the policy covers when it is not the default<br/>
        /// Example: [0df9e665-d932-5740-b2c7-b52af166bc11]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationAccountGuardrailPolicyRequest(
            global::OpenRouter.GuardrailModerationPolicyConfig config,
            string name,
            global::OpenRouter.ModerationAccountGuardrailPolicyRequestFloorReassignment? floorReassignment,
            bool? isDefault,
            bool? keepPreviousDefaultWorkspaces,
            global::System.Collections.Generic.IList<global::System.Guid>? optedOutWorkspaceIds,
            global::OpenRouter.ModerationAccountGuardrailPolicyRequestPolicyType policyType,
            global::System.Collections.Generic.IList<global::System.Guid>? releasedFloorWorkspaceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.FloorReassignment = floorReassignment;
            this.IsDefault = isDefault;
            this.KeepPreviousDefaultWorkspaces = keepPreviousDefaultWorkspaces;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OptedOutWorkspaceIds = optedOutWorkspaceIds;
            this.PolicyType = policyType;
            this.ReleasedFloorWorkspaceIds = releasedFloorWorkspaceIds;
            this.WorkspaceIds = workspaceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationAccountGuardrailPolicyRequest" /> class.
        /// </summary>
        public ModerationAccountGuardrailPolicyRequest()
        {
        }

    }
}