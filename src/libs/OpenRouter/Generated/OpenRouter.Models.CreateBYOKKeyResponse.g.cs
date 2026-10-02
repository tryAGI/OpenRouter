
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"allowed_api_key_hashes":null,"allowed_models":null,"allowed_user_ids":null,"created_at":"2025-08-24T10:30:00Z","declared_zdr":null,"disabled":false,"id":"11111111-2222-3333-4444-555555555555","is_byok_only":false,"is_fallback":false,"is_required":false,"label":"sk-...AbCd","name":"Production OpenAI Key","provider":"openai","sort_order":0,"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}}
    /// </summary>
    public sealed partial class CreateBYOKKeyResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.BYOKKey, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.BYOKKey, object> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBYOKKeyResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBYOKKeyResponse(
            global::OpenRouter.AllOf<global::OpenRouter.BYOKKey, object> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBYOKKeyResponse" /> class.
        /// </summary>
        public CreateBYOKKeyResponse()
        {
        }

    }
}