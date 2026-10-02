
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"code":"print(\u0022hello\u0022)","id":"ci_abc123","outputs":[{"logs":"hello\n","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
    /// </summary>
    public sealed partial class OutputItemCodeInterpreterCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputsItem>? Outputs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemCodeInterpreterCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputItemCodeInterpreterCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemCodeInterpreterCallTypeJsonConverter))]
        public global::OpenRouter.OutputItemCodeInterpreterCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemCodeInterpreterCall" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="code"></param>
        /// <param name="containerId"></param>
        /// <param name="outputs"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemCodeInterpreterCall(
            string id,
            global::OpenRouter.OutputItemCodeInterpreterCallStatus status,
            string? code,
            string? containerId,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputsItem>? outputs,
            global::OpenRouter.OutputItemCodeInterpreterCallType type)
        {
            this.Code = code;
            this.ContainerId = containerId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Outputs = outputs;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemCodeInterpreterCall" /> class.
        /// </summary>
        public OutputItemCodeInterpreterCall()
        {
        }

    }
}