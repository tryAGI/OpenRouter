
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A code interpreter execution call with outputs
    /// </summary>
    public sealed partial class OutputCodeInterpreterCallItem
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

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
        public global::System.Collections.Generic.IList<global::OpenRouter.CodeInterpreterCallItemOutputsItems>? Outputs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterCallItemTypeJsonConverter))]
        public global::OpenRouter.CodeInterpreterCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCodeInterpreterCallItem" /> class.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="code"></param>
        /// <param name="outputs"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputCodeInterpreterCallItem(
            string containerId,
            string id,
            global::OpenRouter.ToolCallStatus status,
            string? code,
            global::System.Collections.Generic.IList<global::OpenRouter.CodeInterpreterCallItemOutputsItems>? outputs,
            global::OpenRouter.CodeInterpreterCallItemType type)
        {
            this.Code = code;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Outputs = outputs;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCodeInterpreterCallItem" /> class.
        /// </summary>
        public OutputCodeInterpreterCallItem()
        {
        }
    }
}