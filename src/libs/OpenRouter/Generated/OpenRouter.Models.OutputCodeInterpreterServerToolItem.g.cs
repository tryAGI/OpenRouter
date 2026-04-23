
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:code_interpreter server tool output item
    /// </summary>
    public sealed partial class OutputCodeInterpreterServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public string? Stderr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public string? Stdout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputCodeInterpreterServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCodeInterpreterServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="code"></param>
        /// <param name="exitCode"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputCodeInterpreterServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? code,
            int? exitCode,
            string? id,
            string? language,
            string? stderr,
            string? stdout,
            global::OpenRouter.OutputCodeInterpreterServerToolItemType type)
        {
            this.Code = code;
            this.ExitCode = exitCode;
            this.Id = id;
            this.Language = language;
            this.Status = status;
            this.Stderr = stderr;
            this.Stdout = stdout;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCodeInterpreterServerToolItem" /> class.
        /// </summary>
        public OutputCodeInterpreterServerToolItem()
        {
        }
    }
}