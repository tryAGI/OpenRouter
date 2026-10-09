
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A tool search call the client executed<br/>
    /// Example: {"arguments":{"query":"weather"},"call_id":"call_search_1","execution":"client","status":"completed","type":"tool_search_call"}
    /// </summary>
    public sealed partial class ToolSearchCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchCallItemExecutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolSearchCallItemExecution Execution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchCallItemStatusJsonConverter))]
        public global::OpenRouter.ToolSearchCallItemStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchCallItemTypeJsonConverter))]
        public global::OpenRouter.ToolSearchCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCallItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="execution"></param>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchCallItem(
            string callId,
            global::OpenRouter.ToolSearchCallItemExecution execution,
            object? arguments,
            string? id,
            global::OpenRouter.ToolSearchCallItemStatus? status,
            global::OpenRouter.ToolSearchCallItemType type)
        {
            this.Arguments = arguments;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Execution = execution;
            this.Id = id;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchCallItem" /> class.
        /// </summary>
        public ToolSearchCallItem()
        {
        }

    }
}