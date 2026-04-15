
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultContextManagement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_edits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems> AppliedEdits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultContextManagement" /> class.
        /// </summary>
        /// <param name="appliedEdits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultContextManagement(
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems> appliedEdits)
        {
            this.AppliedEdits = appliedEdits ?? throw new global::System.ArgumentNullException(nameof(appliedEdits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultContextManagement" /> class.
        /// </summary>
        public MessagesResultContextManagement()
        {
        }
    }
}