
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion choice
    /// </summary>
    public sealed partial class ChatChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatFinishReasonEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatFinishReasonEnum FinishReason { get; set; }

        /// <summary>
        /// Choice index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Log probabilities for the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::OpenRouter.ChatTokenLogprobs? Logprobs { get; set; }

        /// <summary>
        /// Assistant message for requests and responses
        /// </summary>
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
        /// <param name="finishReason"></param>
        /// <param name="index">
        /// Choice index
        /// </param>
        /// <param name="message">
        /// Assistant message for requests and responses
        /// </param>
        /// <param name="logprobs">
        /// Log probabilities for the completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatChoice(
            global::OpenRouter.ChatFinishReasonEnum finishReason,
            int index,
            global::OpenRouter.ChatAssistantMessage message,
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