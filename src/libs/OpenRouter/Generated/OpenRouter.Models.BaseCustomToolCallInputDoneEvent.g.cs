
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a custom tool call's freeform input streaming is complete. Mirrors `response.function_call_arguments.done` but for `custom` tools.<br/>
    /// Example: {"input":"*** Begin Patch\n*** End Patch","item_id":"item-1","output_index":0,"sequence_number":6,"type":"response.custom_tool_call_input.done"}
    /// </summary>
    public sealed partial class BaseCustomToolCallInputDoneEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseCustomToolCallInputDoneEventTypeJsonConverter))]
        public global::OpenRouter.BaseCustomToolCallInputDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCustomToolCallInputDoneEvent" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseCustomToolCallInputDoneEvent(
            string input,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.BaseCustomToolCallInputDoneEventType type)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCustomToolCallInputDoneEvent" /> class.
        /// </summary>
        public BaseCustomToolCallInputDoneEvent()
        {
        }

    }
}