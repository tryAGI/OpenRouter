
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1Choice
    {
        /// <summary>
        /// Example: stop
        /// </summary>
        /// <example>stop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FinishReason FinishReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobs? Logprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessage Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_finish_reason")]
        public string? NativeFinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1Choice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// Example: stop
        /// </param>
        /// <param name="index"></param>
        /// <param name="message"></param>
        /// <param name="logprobs"></param>
        /// <param name="nativeFinishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1Choice(
            global::OpenRouter.FinishReason finishReason,
            int index,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessage message,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobs? logprobs,
            string? nativeFinishReason)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.NativeFinishReason = nativeFinishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1Choice" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1Choice()
        {
        }

    }
}