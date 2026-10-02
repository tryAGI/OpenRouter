
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when function call arguments streaming is complete<br/>
    /// Example: {"arguments":"{\u0022city\u0022: \u0022San Francisco\u0022, \u0022units\u0022: \u0022celsius\u0022}","item_id":"item-1","name":"get_weather","output_index":0,"sequence_number":6,"type":"response.function_call_arguments.done"}
    /// </summary>
    public sealed partial class BaseFunctionCallArgsDoneEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseFunctionCallArgsDoneEventTypeJsonConverter))]
        public global::OpenRouter.BaseFunctionCallArgsDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFunctionCallArgsDoneEvent" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="itemId"></param>
        /// <param name="name"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseFunctionCallArgsDoneEvent(
            string arguments,
            string itemId,
            string name,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.BaseFunctionCallArgsDoneEventType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFunctionCallArgsDoneEvent" /> class.
        /// </summary>
        public BaseFunctionCallArgsDoneEvent()
        {
        }

    }
}