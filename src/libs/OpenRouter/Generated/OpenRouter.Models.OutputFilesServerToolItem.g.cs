
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:files server tool output item
    /// </summary>
    public sealed partial class OutputFilesServerToolItem
    {
        /// <summary>
        /// Error message when the file operation failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The target file id supplied in the tool-call arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The target filename supplied in the tool-call arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The file operation performed (list, read, write, or edit).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }

        /// <summary>
        /// JSON-serialized result of the file operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFilesServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="error">
        /// Error message when the file operation failed.
        /// </param>
        /// <param name="fileId">
        /// The target file id supplied in the tool-call arguments.
        /// </param>
        /// <param name="filename">
        /// The target filename supplied in the tool-call arguments.
        /// </param>
        /// <param name="id"></param>
        /// <param name="operation">
        /// The file operation performed (list, read, write, or edit).
        /// </param>
        /// <param name="result">
        /// JSON-serialized result of the file operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFilesServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? error,
            string? fileId,
            string? filename,
            string? id,
            string? operation,
            string? result)
        {
            this.Error = error;
            this.FileId = fileId;
            this.Filename = filename;
            this.Id = id;
            this.Operation = operation;
            this.Result = result;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFilesServerToolItem" /> class.
        /// </summary>
        public OutputFilesServerToolItem()
        {
        }

    }
}