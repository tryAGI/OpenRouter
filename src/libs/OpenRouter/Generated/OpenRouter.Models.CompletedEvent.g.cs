
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a response has completed successfully<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[{"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"item-1","role":"assistant","status":"completed","type":"message"}],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":10,"type":"response.completed"}
    /// </summary>
    public sealed partial class CompletedEvent
    {
        /// <summary>
        /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null}
        /// </summary>
        /// <example>{"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BaseResponsesResult Response { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CompletedEventTypeJsonConverter))]
        public global::OpenRouter.CompletedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedEvent" /> class.
        /// </summary>
        /// <param name="response">
        /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null}
        /// </param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletedEvent(
            global::OpenRouter.BaseResponsesResult response,
            int sequenceNumber,
            global::OpenRouter.CompletedEventType type)
        {
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedEvent" /> class.
        /// </summary>
        public CompletedEvent()
        {
        }

    }
}