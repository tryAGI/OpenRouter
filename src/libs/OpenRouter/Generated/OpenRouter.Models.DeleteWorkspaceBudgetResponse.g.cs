
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWorkspaceBudgetResponse
    {
        /// <summary>
        /// Confirmation that the budget was deleted (or did not exist)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorkspaceBudgetResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Confirmation that the budget was deleted (or did not exist)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWorkspaceBudgetResponse(
            bool deleted)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWorkspaceBudgetResponse" /> class.
        /// </summary>
        public DeleteWorkspaceBudgetResponse()
        {
        }

    }
}