
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OutputFunctionCallItemVariant2
    {
        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. String id that matches the `call_id` of the `openrouter:subagent` server tool call that spawned the subagent. Present on every `function_call` item the subagent projects; absent on ordinary function calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagent_id")]
        public string? SubagentId { get; set; }

        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. The subagent's output items produced on this turn. Treat this as an opaque object; you must replay it in the request so that the subagent can continue execution of the tool with the same context. If a subagent created multiple parallel tool calls, only the first tool call will have this field. The other tool calls will only have `subagent_id`. Present only if the tool call originates from a subagent spawned by the `openrouter:subagent` server tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagent_items")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? SubagentItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFunctionCallItemVariant2" /> class.
        /// </summary>
        /// <param name="subagentId">
        /// EXPERIMENTAL — subject to change without notice. String id that matches the `call_id` of the `openrouter:subagent` server tool call that spawned the subagent. Present on every `function_call` item the subagent projects; absent on ordinary function calls.
        /// </param>
        /// <param name="subagentItems">
        /// EXPERIMENTAL — subject to change without notice. The subagent's output items produced on this turn. Treat this as an opaque object; you must replay it in the request so that the subagent can continue execution of the tool with the same context. If a subagent created multiple parallel tool calls, only the first tool call will have this field. The other tool calls will only have `subagent_id`. Present only if the tool call originates from a subagent spawned by the `openrouter:subagent` server tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFunctionCallItemVariant2(
            string? subagentId,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? subagentItems)
        {
            this.SubagentId = subagentId;
            this.SubagentItems = subagentItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFunctionCallItemVariant2" /> class.
        /// </summary>
        public OutputFunctionCallItemVariant2()
        {
        }

    }
}