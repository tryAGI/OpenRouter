
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertWorkspaceBudgetResponse
    {
        /// <summary>
        /// The created or updated budget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UpsertWorkspaceBudgetResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertWorkspaceBudgetResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The created or updated budget
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertWorkspaceBudgetResponse(
            global::OpenRouter.UpsertWorkspaceBudgetResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertWorkspaceBudgetResponse" /> class.
        /// </summary>
        public UpsertWorkspaceBudgetResponse()
        {
        }

    }
}