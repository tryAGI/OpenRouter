
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A page of files in OpenAI's shape.<br/>
    /// Example: {"_shape":"openai","data":[],"first_id":null,"has_more":false,"last_id":null,"object":"list"}
    /// </summary>
    public sealed partial class OpenAIFileList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileListShapeJsonConverter))]
        public global::OpenRouter.OpenAIFileListShape Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OpenAIFile> Data { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileListObjectJsonConverter))]
        public global::OpenRouter.OpenAIFileListObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFileList" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore"></param>
        /// <param name="shape"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFileList(
            global::System.Collections.Generic.IList<global::OpenRouter.OpenAIFile> data,
            bool hasMore,
            global::OpenRouter.OpenAIFileListShape shape,
            string? firstId,
            string? lastId,
            global::OpenRouter.OpenAIFileListObject @object)
        {
            this.Shape = shape;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFileList" /> class.
        /// </summary>
        public OpenAIFileList()
        {
        }

    }
}