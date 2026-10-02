
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Validate and activate in the same call. On a failed validation the draft is kept and returned with a 422, so fix it and call `/validate` and `/activate` instead of creating it again.<br/>
    /// Example: {"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    public sealed partial class PrivateEndpointActivation
    {
        /// <summary>
        /// Workspace whose BYOK credential is used for the live validation call. The workspace must belong to your account.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointActivation" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace whose BYOK credential is used for the live validation call. The workspace must belong to your account.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointActivation(
            global::System.Guid workspaceId)
        {
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointActivation" /> class.
        /// </summary>
        public PrivateEndpointActivation()
        {
        }

    }
}