
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A function call initiated by the model<br/>
    /// Example: {"arguments":"{\u0022location\u0022:\u0022San Francisco\u0022}","call_id":"call-abc123","id":"call-abc123","name":"get_weather","status":"completed","type":"function_call"}
    /// </summary>
    public sealed partial class FunctionCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// True when the model called a tool declared with `async: true` and may continue its turn before the output is returned. Return the result in a later request as a `function_call_output` with this `call_id`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Namespace qualifier for tools registered as part of a namespace tool group (e.g. an MCP server)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::OpenRouter.ToolCallStatus? Status { get; set; }

        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. String id that matches the `call_id` of the `openrouter:subagent` server tool call that spawned the subagent. Present on every `function_call` item the subagent projects; absent on ordinary function calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagent_id")]
        public string? SubagentId { get; set; }

        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. The subagent's output items produced on this turn. Treat this as an opaque object; you must replay it in the request so that the subagent can continue execution of the tool with the same context. If a subagent created multiple parallel tool calls, only the first tool call will have this field. The other tool calls will only have `subagent_id`. Present only if the tool call originates from a subagent spawned by the `openrouter:subagent` server tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagent_items")]
        public global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallItemSubagentItem>? SubagentItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FunctionCallItemTypeJsonConverter))]
        public global::OpenRouter.FunctionCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallItem" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="async">
        /// True when the model called a tool declared with `async: true` and may continue its turn before the output is returned. Return the result in a later request as a `function_call_output` with this `call_id`.<br/>
        /// Example: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="namespace">
        /// Namespace qualifier for tools registered as part of a namespace tool group (e.g. an MCP server)
        /// </param>
        /// <param name="status"></param>
        /// <param name="subagentId">
        /// EXPERIMENTAL — subject to change without notice. String id that matches the `call_id` of the `openrouter:subagent` server tool call that spawned the subagent. Present on every `function_call` item the subagent projects; absent on ordinary function calls.
        /// </param>
        /// <param name="subagentItems">
        /// EXPERIMENTAL — subject to change without notice. The subagent's output items produced on this turn. Treat this as an opaque object; you must replay it in the request so that the subagent can continue execution of the tool with the same context. If a subagent created multiple parallel tool calls, only the first tool call will have this field. The other tool calls will only have `subagent_id`. Present only if the tool call originates from a subagent spawned by the `openrouter:subagent` server tool.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallItem(
            string arguments,
            string callId,
            string name,
            bool? async,
            string? id,
            string? @namespace,
            global::OpenRouter.ToolCallStatus? status,
            string? subagentId,
            global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallItemSubagentItem>? subagentItems,
            global::OpenRouter.FunctionCallItemType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Async = async;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Namespace = @namespace;
            this.Status = status;
            this.SubagentId = subagentId;
            this.SubagentItems = subagentItems;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallItem" /> class.
        /// </summary>
        public FunctionCallItem()
        {
        }

    }
}