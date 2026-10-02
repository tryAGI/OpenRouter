
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The single choice this endpoint streams.<br/>
    /// Example: {"delta":{"content":"Hello"},"finish_reason":null,"index":0}
    /// </summary>
    public sealed partial class InternChatChoice
    {
        /// <summary>
        /// The incremental content of one chunk. The first chunk carries `role`, text chunks carry `content`, reasoning chunks carry `reasoning`, and an interaction chunk carries one complete `tool_calls` entry.<br/>
        /// Example: {"content":"Hello"}
        /// </summary>
        /// <example>{"content":"Hello"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatDelta Delta { get; set; }

        /// <summary>
        /// `null` while streaming. `stop` when the run completed, `tool_calls` when the run is waiting for the caller to answer the streamed tool call, `error` on the terminal error chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatChoiceFinishReasonJsonConverter))]
        public global::OpenRouter.InternChatChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatChoice" /> class.
        /// </summary>
        /// <param name="delta">
        /// The incremental content of one chunk. The first chunk carries `role`, text chunks carry `content`, reasoning chunks carry `reasoning`, and an interaction chunk carries one complete `tool_calls` entry.<br/>
        /// Example: {"content":"Hello"}
        /// </param>
        /// <param name="index"></param>
        /// <param name="finishReason">
        /// `null` while streaming. `stop` when the run completed, `tool_calls` when the run is waiting for the caller to answer the streamed tool call, `error` on the terminal error chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatChoice(
            global::OpenRouter.InternChatDelta delta,
            int index,
            global::OpenRouter.InternChatChoiceFinishReason? finishReason)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatChoice" /> class.
        /// </summary>
        public InternChatChoice()
        {
        }

    }
}