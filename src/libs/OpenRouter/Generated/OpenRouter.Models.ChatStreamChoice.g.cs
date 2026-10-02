
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Streaming completion choice chunk<br/>
    /// Example: {"delta":{"content":"Hello","role":"assistant"},"finish_reason":null,"index":0}
    /// </summary>
    public sealed partial class ChatStreamChoice
    {
        /// <summary>
        /// Delta changes in streaming response<br/>
        /// Example: {"content":"Hello","role":"assistant"}
        /// </summary>
        /// <example>{"content":"Hello","role":"assistant"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatStreamDelta Delta { get; set; }

        /// <summary>
        /// Example: stop
        /// </summary>
        /// <example>stop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatFinishReasonEnumJsonConverter))]
        public global::OpenRouter.ChatFinishReasonEnum? FinishReason { get; set; }

        /// <summary>
        /// Choice index<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Log probabilities for the completion<br/>
        /// Example: {"content":[{"bytes":null,"logprob":-0.612345,"token":" Hello","top_logprobs":[]}],"refusal":null}
        /// </summary>
        /// <example>{"content":[{"bytes":null,"logprob":-0.612345,"token":" Hello","top_logprobs":[]}],"refusal":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::OpenRouter.ChatTokenLogprobs? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChoice" /> class.
        /// </summary>
        /// <param name="delta">
        /// Delta changes in streaming response<br/>
        /// Example: {"content":"Hello","role":"assistant"}
        /// </param>
        /// <param name="index">
        /// Choice index<br/>
        /// Example: 0
        /// </param>
        /// <param name="finishReason">
        /// Example: stop
        /// </param>
        /// <param name="logprobs">
        /// Log probabilities for the completion<br/>
        /// Example: {"content":[{"bytes":null,"logprob":-0.612345,"token":" Hello","top_logprobs":[]}],"refusal":null}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamChoice(
            global::OpenRouter.ChatStreamDelta delta,
            int index,
            global::OpenRouter.ChatFinishReasonEnum? finishReason,
            global::OpenRouter.ChatTokenLogprobs? logprobs)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChoice" /> class.
        /// </summary>
        public ChatStreamChoice()
        {
        }

    }
}