
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"choices":[{"delta":{"content":"Hello","role":"assistant"},"finish_reason":null,"index":0}],"created":1677652288,"id":"chatcmpl-123","model":"openai/gpt-4","object":"chat.completion.chunk"}}
    /// </summary>
    public sealed partial class ChatStreamingResponse
    {
        /// <summary>
        /// Streaming chat completion chunk<br/>
        /// Example: {"choices":[{"delta":{"content":"Hello","role":"assistant"},"finish_reason":null,"index":0}],"created":1677652288,"id":"chatcmpl-123","model":"openai/gpt-4","object":"chat.completion.chunk"}
        /// </summary>
        /// <example>{"choices":[{"delta":{"content":"Hello","role":"assistant"},"finish_reason":null,"index":0}],"created":1677652288,"id":"chatcmpl-123","model":"openai/gpt-4","object":"chat.completion.chunk"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatStreamChunk Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Streaming chat completion chunk<br/>
        /// Example: {"choices":[{"delta":{"content":"Hello","role":"assistant"},"finish_reason":null,"index":0}],"created":1677652288,"id":"chatcmpl-123","model":"openai/gpt-4","object":"chat.completion.chunk"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamingResponse(
            global::OpenRouter.ChatStreamChunk data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamingResponse" /> class.
        /// </summary>
        public ChatStreamingResponse()
        {
        }

    }
}