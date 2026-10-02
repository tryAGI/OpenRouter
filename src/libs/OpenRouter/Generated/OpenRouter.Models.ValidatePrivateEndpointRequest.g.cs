
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidatePrivateEndpointRequest
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
        /// Initializes a new instance of the <see cref="ValidatePrivateEndpointRequest" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace whose BYOK credential is used for the live validation call. The workspace must belong to your account.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidatePrivateEndpointRequest(
            global::System.Guid workspaceId)
        {
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatePrivateEndpointRequest" /> class.
        /// </summary>
        public ValidatePrivateEndpointRequest()
        {
        }

    }
}