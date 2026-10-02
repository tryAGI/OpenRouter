
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A page of files in Anthropic's shape.<br/>
    /// Example: {"_shape":"anthropic","data":[],"first_id":null,"has_more":false,"last_id":null}
    /// </summary>
    public sealed partial class AnthropicFileList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicFileListShapeJsonConverter))]
        public global::OpenRouter.AnthropicFileListShape Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnthropicFile> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicFileList" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore"></param>
        /// <param name="shape"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicFileList(
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicFile> data,
            bool hasMore,
            global::OpenRouter.AnthropicFileListShape shape,
            string? firstId,
            string? lastId)
        {
            this.Shape = shape;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicFileList" /> class.
        /// </summary>
        public AnthropicFileList()
        {
        }

    }
}