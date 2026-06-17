
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertWorkspaceBudgetRequest
    {
        /// <summary>
        /// Spending limit in USD. Must be greater than 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertWorkspaceBudgetRequest" /> class.
        /// </summary>
        /// <param name="limitUsd">
        /// Spending limit in USD. Must be greater than 0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertWorkspaceBudgetRequest(
            double limitUsd)
        {
            this.LimitUsd = limitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertWorkspaceBudgetRequest" /> class.
        /// </summary>
        public UpsertWorkspaceBudgetRequest()
        {
        }

    }
}