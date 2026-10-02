
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"created_at":"2025-08-24T10:30:00Z","created_by":"user_abc123","default_guardrail_id":"595d5849-7e86-51fd-a7c0-705c34e4afff","default_image_model":"openai/dall-e-3","default_provider_sort":"price","default_text_model":"openai/gpt-4o","description":"Production environment workspace","disabled_server_tools":null,"id":"550e8400-e29b-41d4-a716-446655440000","include_byok_in_budgets":false,"io_logging_api_key_ids":null,"io_logging_sampling_rate":1,"is_data_discount_logging_enabled":true,"is_observability_broadcast_enabled":false,"is_observability_io_logging_enabled":false,"name":"Production","slug":"production","updated_at":"2025-08-24T15:45:00Z"}}
    /// </summary>
    public sealed partial class GetWorkspaceResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.Workspace, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.Workspace, object> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkspaceResponse(
            global::OpenRouter.AllOf<global::OpenRouter.Workspace, object> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceResponse" /> class.
        /// </summary>
        public GetWorkspaceResponse()
        {
        }

    }
}