
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:bash server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant9
    {
        /// <summary>
        /// Discriminator value: openrouter:bash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant9TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant9Type Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant9" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:bash
        /// </param>
        /// <param name="command"></param>
        /// <param name="exitCode"></param>
        /// <param name="id"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant9(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant9Type type,
            string? command,
            int? exitCode,
            string? id,
            string? stderr,
            string? stdout)
        {
            this.Type = type;
            this.Command = command;
            this.ExitCode = exitCode;
            this.Id = id;
            this.Status = status;
            this.Stderr = stderr;
            this.Stdout = stdout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant9" /> class.
        /// </summary>
        public OutputItemsVariant9()
        {
        }

    }
}