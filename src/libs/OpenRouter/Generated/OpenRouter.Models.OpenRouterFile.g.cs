
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A stored file in the OpenRouter superset shape: Anthropic-shaped, plus OpenRouter-only fields.<br/>
    /// Example: {"_shape":"openrouter","created_at":"2025-01-01T00:00:00Z","downloadable":false,"filename":"document.pdf","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","mime_type":"application/pdf","size_bytes":1024000,"type":"file"}
    /// </summary>
    public sealed partial class OpenRouterFile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenRouterFileShapeJsonConverter))]
        public global::OpenRouter.OpenRouterFileShape Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Downloadable { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenRouterFileTypeJsonConverter))]
        public global::OpenRouter.OpenRouterFileType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterFile" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="downloadable"></param>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <param name="mimeType"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="shape"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRouterFile(
            string createdAt,
            bool downloadable,
            string filename,
            string id,
            string mimeType,
            long sizeBytes,
            global::OpenRouter.OpenRouterFileShape shape,
            global::OpenRouter.OpenRouterFileType type)
        {
            this.Shape = shape;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Downloadable = downloadable;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterFile" /> class.
        /// </summary>
        public OpenRouterFile()
        {
        }

    }
}