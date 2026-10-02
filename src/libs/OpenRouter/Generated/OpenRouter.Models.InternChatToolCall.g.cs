
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An `openrouter.provide_input` request. The run pauses on the daemon until a `tool` message answers it, the caller cancels it, or its interaction deadline passes.<br/>
    /// Example: {"function":{"arguments":"{\u0022fields\u0022:[{\u0022name\u0022:\u0022answer\u0022,\u0022options\u0022:[\u0022red\u0022,\u0022blue\u0022,\u0022Other\u0022],\u0022required\u0022:true,\u0022type\u0022:\u0022string\u0022}],\u0022kind\u0022:\u0022elicitation\u0022,\u0022message\u0022:\u0022Which colour do you prefer?\u0022}","name":"openrouter.provide_input"},"id":"15e90ad6-5320-4a59-af4f-b371428154fa","index":0,"type":"function"}
    /// </summary>
    public sealed partial class InternChatToolCall
    {
        /// <summary>
        /// The single tool this endpoint calls, asking the caller for input.<br/>
        /// Example: {"arguments":"{\u0022fields\u0022:[{\u0022name\u0022:\u0022answer\u0022,\u0022options\u0022:[\u0022red\u0022,\u0022blue\u0022,\u0022Other\u0022],\u0022required\u0022:true,\u0022type\u0022:\u0022string\u0022}],\u0022kind\u0022:\u0022elicitation\u0022,\u0022message\u0022:\u0022Which colour do you prefer?\u0022}","name":"openrouter.provide_input"}
        /// </summary>
        /// <example>{"arguments":"{\u0022fields\u0022:[{\u0022name\u0022:\u0022answer\u0022,\u0022options\u0022:[\u0022red\u0022,\u0022blue\u0022,\u0022Other\u0022],\u0022required\u0022:true,\u0022type\u0022:\u0022string\u0022}],\u0022kind\u0022:\u0022elicitation\u0022,\u0022message\u0022:\u0022Which colour do you prefer?\u0022}","name":"openrouter.provide_input"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatToolCallFunction Function { get; set; }

        /// <summary>
        /// The interaction id. Send it back as `tool_call_id` on the `tool` message that answers it.<br/>
        /// Example: 15e90ad6-5320-4a59-af4f-b371428154fa
        /// </summary>
        /// <example>15e90ad6-5320-4a59-af4f-b371428154fa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatToolCallTypeJsonConverter))]
        public global::OpenRouter.InternChatToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatToolCall" /> class.
        /// </summary>
        /// <param name="function">
        /// The single tool this endpoint calls, asking the caller for input.<br/>
        /// Example: {"arguments":"{\u0022fields\u0022:[{\u0022name\u0022:\u0022answer\u0022,\u0022options\u0022:[\u0022red\u0022,\u0022blue\u0022,\u0022Other\u0022],\u0022required\u0022:true,\u0022type\u0022:\u0022string\u0022}],\u0022kind\u0022:\u0022elicitation\u0022,\u0022message\u0022:\u0022Which colour do you prefer?\u0022}","name":"openrouter.provide_input"}
        /// </param>
        /// <param name="id">
        /// The interaction id. Send it back as `tool_call_id` on the `tool` message that answers it.<br/>
        /// Example: 15e90ad6-5320-4a59-af4f-b371428154fa
        /// </param>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatToolCall(
            global::OpenRouter.InternChatToolCallFunction function,
            string id,
            int index,
            global::OpenRouter.InternChatToolCallType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatToolCall" /> class.
        /// </summary>
        public InternChatToolCall()
        {
        }

    }
}