
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A stored file in OpenAI's Files API shape.<br/>
    /// Example: {"_shape":"openai","bytes":1024000,"created_at":1735689600,"filename":"document.pdf","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","object":"file","purpose":"user_data","status":"processed"}
    /// </summary>
    public sealed partial class OpenAIFile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileShapeJsonConverter))]
        public global::OpenRouter.OpenAIFileShape Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Bytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileObjectJsonConverter))]
        public global::OpenRouter.OpenAIFileObject Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAIFilePurpose Purpose { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileStatusJsonConverter))]
        public global::OpenRouter.OpenAIFileStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFile" /> class.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="createdAt"></param>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <param name="purpose"></param>
        /// <param name="shape"></param>
        /// <param name="object"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFile(
            long bytes,
            int createdAt,
            string filename,
            string id,
            global::OpenRouter.OpenAIFilePurpose purpose,
            global::OpenRouter.OpenAIFileShape shape,
            global::OpenRouter.OpenAIFileObject @object,
            global::OpenRouter.OpenAIFileStatus status)
        {
            this.Shape = shape;
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Purpose = purpose;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFile" /> class.
        /// </summary>
        public OpenAIFile()
        {
        }

    }
}