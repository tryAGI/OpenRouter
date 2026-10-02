
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Optional consent for a teardown that discards the workspace.<br/>
    /// Example: {"acknowledge_workspace_loss":true}
    /// </summary>
    public sealed partial class DeleteInternRequest
    {
        /// <summary>
        /// Delete even though the workspace backup was not confirmed. Defaults to false, which refuses the teardown when a workspace archive is missing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledge_workspace_loss")]
        public bool? AcknowledgeWorkspaceLoss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInternRequest" /> class.
        /// </summary>
        /// <param name="acknowledgeWorkspaceLoss">
        /// Delete even though the workspace backup was not confirmed. Defaults to false, which refuses the teardown when a workspace archive is missing.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteInternRequest(
            bool? acknowledgeWorkspaceLoss)
        {
            this.AcknowledgeWorkspaceLoss = acknowledgeWorkspaceLoss;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInternRequest" /> class.
        /// </summary>
        public DeleteInternRequest()
        {
        }

    }
}