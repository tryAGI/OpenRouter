
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBYOKKeysResponse
    {
        /// <summary>
        /// List of BYOK credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BYOKKey> Data { get; set; }

        /// <summary>
        /// Total number of BYOK credentials matching the filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBYOKKeysResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of BYOK credentials.
        /// </param>
        /// <param name="totalCount">
        /// Total number of BYOK credentials matching the filters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBYOKKeysResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.BYOKKey> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBYOKKeysResponse" /> class.
        /// </summary>
        public ListBYOKKeysResponse()
        {
        }

    }
}