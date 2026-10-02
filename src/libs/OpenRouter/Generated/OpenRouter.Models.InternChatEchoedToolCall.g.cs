
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `openrouter.provide_input` tool call from the previous response, echoed back unchanged. Its `id` is the interaction the following `tool` message answers.<br/>
    /// Example: {"function":{"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"},"id":"15e90ad6-5320-4a59-af4f-b371428154fa"}
    /// </summary>
    public sealed partial class InternChatEchoedToolCall
    {
        /// <summary>
        /// The function name and JSON arguments string exactly as streamed.<br/>
        /// Example: {"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"}
        /// </summary>
        /// <example>{"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatEchoedToolCallFunction Function { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatEchoedToolCall" /> class.
        /// </summary>
        /// <param name="function">
        /// The function name and JSON arguments string exactly as streamed.<br/>
        /// Example: {"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"}
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatEchoedToolCall(
            global::OpenRouter.InternChatEchoedToolCallFunction function,
            string id)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatEchoedToolCall" /> class.
        /// </summary>
        public InternChatEchoedToolCall()
        {
        }

    }
}