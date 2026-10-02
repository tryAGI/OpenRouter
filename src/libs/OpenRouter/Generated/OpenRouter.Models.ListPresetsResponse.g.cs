
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A paginated list of presets.<br/>
    /// Example: {"data":[{"created_at":"2026-04-20T10:00:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","description":null,"designated_version_id":"550e8400-e29b-41d4-a716-446655440000","id":"650e8400-e29b-41d4-a716-446655440001","name":"my-preset","slug":"my-preset","status":"active","status_updated_at":null,"updated_at":"2026-04-20T10:00:00Z","workspace_id":"750e8400-e29b-41d4-a716-446655440002"}],"total_count":1}
    /// </summary>
    public sealed partial class ListPresetsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Preset> Data { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="ListPresetsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPresetsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.Preset> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPresetsResponse" /> class.
        /// </summary>
        public ListPresetsResponse()
        {
        }

    }
}