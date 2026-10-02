
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:files server tool output item<br/>
    /// Example: {"filename":"notes.txt","id":"fl_tmp_abc123","operation":"read","result":"{\u0022id\u0022:\u0022file_abc\u0022,\u0022filename\u0022:\u0022notes.txt\u0022,\u0022content\u0022:\u0022hello\u0022}","status":"completed","type":"openrouter:files"}
    /// </summary>
    public sealed partial class OutputFilesServerToolItem
    {
        /// <summary>
        /// The raw tool-call arguments string as emitted by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The model-generated tool call id from the originating turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

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
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputFilesServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputFilesServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFilesServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="arguments">
        /// The raw tool-call arguments string as emitted by the model.
        /// </param>
        /// <param name="callId">
        /// The model-generated tool call id from the originating turn.
        /// </param>
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
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFilesServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? arguments,
            string? callId,
            string? error,
            string? fileId,
            string? filename,
            string? id,
            string? operation,
            string? result,
            global::OpenRouter.OutputFilesServerToolItemType type)
        {
            this.Arguments = arguments;
            this.CallId = callId;
            this.Error = error;
            this.FileId = fileId;
            this.Filename = filename;
            this.Id = id;
            this.Operation = operation;
            this.Result = result;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFilesServerToolItem" /> class.
        /// </summary>
        public OutputFilesServerToolItem()
        {
        }

    }
}