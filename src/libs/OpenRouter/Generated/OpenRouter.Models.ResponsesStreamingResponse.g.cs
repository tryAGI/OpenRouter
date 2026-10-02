
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"content_index":0,"delta":"Hello","item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":4,"type":"response.output_text.delta"}}
    /// </summary>
    public sealed partial class ResponsesStreamingResponse
    {
        /// <summary>
        /// Union of all possible event types emitted during response streaming<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}
        /// </summary>
        /// <example>{"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StreamEventsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.StreamEvents Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesStreamingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Union of all possible event types emitted during response streaming<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesStreamingResponse(
            global::OpenRouter.StreamEvents data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesStreamingResponse" /> class.
        /// </summary>
        public ResponsesStreamingResponse()
        {
        }

    }
}