
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:code_interpreter server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant11
    {
        /// <summary>
        /// Discriminator value: openrouter:code_interpreter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant11TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant11Type Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant11" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:code_interpreter
        /// </param>
        /// <param name="code"></param>
        /// <param name="exitCode"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant11(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant11Type type,
            string? code,
            int? exitCode,
            string? id,
            string? language,
            string? stderr,
            string? stdout)
        {
            this.Type = type;
            this.Code = code;
            this.ExitCode = exitCode;
            this.Id = id;
            this.Language = language;
            this.Status = status;
            this.Stderr = stderr;
            this.Stdout = stdout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant11" /> class.
        /// </summary>
        public OutputItemsVariant11()
        {
        }
    }
}