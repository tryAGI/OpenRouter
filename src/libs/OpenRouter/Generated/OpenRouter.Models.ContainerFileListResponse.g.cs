
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContainerFileListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ContainerFile> Data { get; set; }

        /// <summary>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </summary>
        /// <example>cfile_b3V0L3JlcG9ydC5jc3Y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// True when another page can be fetched by passing `after=last_id`; `last_id` is non-null whenever this is true.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor for the next page (pass as `after`). The last entry’s id, except when the page stopped at the per-request scan bound on hidden bookkeeping objects: then it names the scan position and may not appear in `data`. Null only when `has_more` is false and `data` is empty.<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </summary>
        /// <example>cfile_b3V0L3JlcG9ydC5jc3Y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerFileListResponseObjectJsonConverter))]
        public global::OpenRouter.ContainerFileListResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// True when another page can be fetched by passing `after=last_id`; `last_id` is non-null whenever this is true.<br/>
        /// Example: false
        /// </param>
        /// <param name="firstId">
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="lastId">
        /// Cursor for the next page (pass as `after`). The last entry’s id, except when the page stopped at the per-request scan bound on hidden bookkeeping objects: then it names the scan position and may not appear in `data`. Null only when `has_more` is false and `data` is empty.<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="object">
        /// Example: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerFileListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ContainerFile> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            global::OpenRouter.ContainerFileListResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileListResponse" /> class.
        /// </summary>
        public ContainerFileListResponse()
        {
        }

    }
}