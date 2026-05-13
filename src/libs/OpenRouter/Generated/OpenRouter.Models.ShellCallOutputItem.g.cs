
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Output from a shell command execution (newer variant)
    /// </summary>
    public sealed partial class ShellCallOutputItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        public int? MaxOutputLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputItemOutputItems> Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        public global::OpenRouter.ToolCallStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellCallOutputItemTypeJsonConverter))]
        public global::OpenRouter.ShellCallOutputItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="id"></param>
        /// <param name="maxOutputLength"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellCallOutputItem(
            string callId,
            global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputItemOutputItems> output,
            string? id,
            int? maxOutputLength,
            global::OpenRouter.ToolCallStatus? status,
            global::OpenRouter.ShellCallOutputItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.MaxOutputLength = maxOutputLength;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallOutputItem" /> class.
        /// </summary>
        public ShellCallOutputItem()
        {
        }

    }
}