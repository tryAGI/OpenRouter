
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// File input content item
    /// </summary>
    public sealed partial class InputFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputFileTypeJsonConverter))]
        public global::OpenRouter.InputFileType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFile" /> class.
        /// </summary>
        /// <param name="fileData"></param>
        /// <param name="fileId"></param>
        /// <param name="fileUrl"></param>
        /// <param name="filename"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFile(
            string? fileData,
            string? fileId,
            string? fileUrl,
            string? filename,
            global::OpenRouter.InputFileType type)
        {
            this.FileData = fileData;
            this.FileId = fileId;
            this.FileUrl = fileUrl;
            this.Filename = filename;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFile" /> class.
        /// </summary>
        public InputFile()
        {
        }
    }
}