
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListBudgetGuardrailPoliciesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BudgetGuardrailPolicySummary> Data { get; set; }

        /// <summary>
        /// Total number of policies<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBudgetGuardrailPoliciesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="totalCount">
        /// Total number of policies<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBudgetGuardrailPoliciesResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.BudgetGuardrailPolicySummary> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBudgetGuardrailPoliciesResponse" /> class.
        /// </summary>
        public ListBudgetGuardrailPoliciesResponse()
        {
        }

    }
}