
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion choice<br/>
    /// Example: {"finish_reason":"stop","index":0,"logprobs":null,"message":{"content":"The capital of France is Paris.","role":"assistant"}}
    /// </summary>
    public sealed partial class ChatChoice
    {
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
        /// Assistant message for requests and responses<br/>
        /// Example: {"content":"The capital of France is Paris.","model":"openai/gpt-4o","role":"assistant"}
        /// </summary>
        /// <example>{"content":"The capital of France is Paris.","model":"openai/gpt-4o","role":"assistant"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatAssistantMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Choice index<br/>
        /// Example: 0
        /// </param>
        /// <param name="message">
        /// Assistant message for requests and responses<br/>
        /// Example: {"content":"The capital of France is Paris.","model":"openai/gpt-4o","role":"assistant"}
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
        public ChatChoice(
            int index,
            global::OpenRouter.ChatAssistantMessage message,
            global::OpenRouter.ChatFinishReasonEnum? finishReason,
            global::OpenRouter.ChatTokenLogprobs? logprobs)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChoice" /> class.
        /// </summary>
        public ChatChoice()
        {
        }

    }
}