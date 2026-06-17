
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWorkspaceBudgetsResponse
    {
        /// <summary>
        /// List of budgets configured for the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceBudgetsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of budgets configured for the workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkspaceBudgetsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceBudgetsResponse" /> class.
        /// </summary>
        public ListWorkspaceBudgetsResponse()
        {
        }

    }
}