
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A server-sent event carrying one chunk. The stream ends with `data: [DONE]`.<br/>
    /// Example: {"data":{"choices":[{"delta":{"tool_calls":[{"function":{"arguments":"{\u0022fields\u0022:[{\u0022name\u0022:\u0022answer\u0022,\u0022options\u0022:[\u0022red\u0022,\u0022blue\u0022,\u0022Other\u0022],\u0022required\u0022:true,\u0022type\u0022:\u0022string\u0022}],\u0022kind\u0022:\u0022elicitation\u0022,\u0022message\u0022:\u0022Which colour do you prefer?\u0022}","name":"openrouter.provide_input"},"id":"15e90ad6-5320-4a59-af4f-b371428154fa","index":0,"type":"function"}]},"finish_reason":null,"index":0}],"created":1789537541,"id":"chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750","model":"openrouter/intern","object":"chat.completion.chunk"}}
    /// </summary>
    public sealed partial class InternChatStreamingResponse
    {
        /// <summary>
        /// One `data:` line of the stream. A run streams a role chunk, content and reasoning chunks, then a finish chunk: `stop`, `tool_calls` (the run is paused for input) or `error` (with an `error` object). A final chunk with empty `choices` follows in every case, carrying `session_id` and `usage` (`null` unless the daemon reported usage, and always `null` after `tool_calls`). Every stream ends with `[DONE]`.<br/>
        /// Example: {"choices":[{"delta":{"content":"Hello"},"finish_reason":null,"index":0}],"created":1789537541,"id":"chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750","model":"openrouter/intern","object":"chat.completion.chunk"}
        /// </summary>
        /// <example>{"choices":[{"delta":{"content":"Hello"},"finish_reason":null,"index":0}],"created":1789537541,"id":"chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750","model":"openrouter/intern","object":"chat.completion.chunk"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatCompletionChunk Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatStreamingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// One `data:` line of the stream. A run streams a role chunk, content and reasoning chunks, then a finish chunk: `stop`, `tool_calls` (the run is paused for input) or `error` (with an `error` object). A final chunk with empty `choices` follows in every case, carrying `session_id` and `usage` (`null` unless the daemon reported usage, and always `null` after `tool_calls`). Every stream ends with `[DONE]`.<br/>
        /// Example: {"choices":[{"delta":{"content":"Hello"},"finish_reason":null,"index":0}],"created":1789537541,"id":"chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750","model":"openrouter/intern","object":"chat.completion.chunk"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatStreamingResponse(
            global::OpenRouter.InternChatCompletionChunk data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatStreamingResponse" /> class.
        /// </summary>
        public InternChatStreamingResponse()
        {
        }

    }
}