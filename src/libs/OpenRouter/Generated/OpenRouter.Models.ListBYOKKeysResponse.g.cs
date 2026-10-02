
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"allowed_api_key_hashes":null,"allowed_models":null,"allowed_user_ids":null,"created_at":"2025-08-24T10:30:00Z","declared_zdr":null,"disabled":false,"id":"11111111-2222-3333-4444-555555555555","is_byok_only":false,"is_fallback":false,"is_required":false,"label":"sk-...AbCd","name":"Production OpenAI Key","provider":"openai","sort_order":0,"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}],"total_count":1}
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
        /// Total number of BYOK credentials matching the filters.<br/>
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
        /// Initializes a new instance of the <see cref="ListBYOKKeysResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of BYOK credentials.
        /// </param>
        /// <param name="totalCount">
        /// Total number of BYOK credentials matching the filters.<br/>
        /// Example: 1
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