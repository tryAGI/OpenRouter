
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:bash server tool output item
    /// </summary>
    public sealed partial class OutputBashServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputBashServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputBashServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBashServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="command"></param>
        /// <param name="exitCode"></param>
        /// <param name="id"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputBashServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? command,
            int? exitCode,
            string? id,
            string? stderr,
            string? stdout,
            global::OpenRouter.OutputBashServerToolItemType type)
        {
            this.Command = command;
            this.ExitCode = exitCode;
            this.Id = id;
            this.Status = status;
            this.Stderr = stderr;
            this.Stdout = stdout;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBashServerToolItem" /> class.
        /// </summary>
        public OutputBashServerToolItem()
        {
        }
    }
}