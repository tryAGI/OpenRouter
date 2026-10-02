
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"created_at":"2025-08-24T10:30:00Z","created_by":"user_abc123","default_guardrail_id":"595d5849-7e86-51fd-a7c0-705c34e4afff","default_image_model":"openai/dall-e-3","default_provider_sort":"price","default_text_model":"openai/gpt-4o","description":"Production environment workspace","disabled_server_tools":null,"id":"550e8400-e29b-41d4-a716-446655440000","include_byok_in_budgets":false,"io_logging_api_key_ids":null,"io_logging_sampling_rate":1,"is_data_discount_logging_enabled":true,"is_observability_broadcast_enabled":false,"is_observability_io_logging_enabled":false,"name":"Production","slug":"production","updated_at":"2025-08-24T15:45:00Z"}],"total_count":1}
    /// </summary>
    public sealed partial class ListWorkspacesResponse
    {
        /// <summary>
        /// List of workspaces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Workspace> Data { get; set; }

        /// <summary>
        /// Total number of workspaces<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspacesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of workspaces
        /// </param>
        /// <param name="totalCount">
        /// Total number of workspaces<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkspacesResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.Workspace> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspacesResponse" /> class.
        /// </summary>
        public ListWorkspacesResponse()
        {
        }

    }
}