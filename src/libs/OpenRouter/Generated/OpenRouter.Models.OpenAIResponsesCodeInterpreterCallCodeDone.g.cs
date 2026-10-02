
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"code":"print(\u0022hello\u0022)","item_id":"ci_abc123","output_index":0,"sequence_number":3,"type":"response.code_interpreter_call_code.done"}
    /// </summary>
    public sealed partial class OpenAIResponsesCodeInterpreterCallCodeDone
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesCodeInterpreterCallCodeDoneTypeJsonConverter))]
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesCodeInterpreterCallCodeDone" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponsesCodeInterpreterCallCodeDone(
            string code,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDoneType type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesCodeInterpreterCallCodeDone" /> class.
        /// </summary>
        public OpenAIResponsesCodeInterpreterCallCodeDone()
        {
        }

    }
}