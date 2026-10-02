
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StreamEventsResponseIncompleteVariant2
    {
        /// <summary>
        /// Complete non-streaming response from the Responses API<br/>
        /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[{"content":[{"annotations":[],"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null,"usage":{"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}}
        /// </summary>
        /// <example>{"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[{"content":[{"annotations":[],"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null,"usage":{"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenResponsesResultJsonConverter))]
        public global::OpenRouter.OpenResponsesResult? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEventsResponseIncompleteVariant2" /> class.
        /// </summary>
        /// <param name="response">
        /// Complete non-streaming response from the Responses API<br/>
        /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[{"content":[{"annotations":[],"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null,"usage":{"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamEventsResponseIncompleteVariant2(
            global::OpenRouter.OpenResponsesResult? response)
        {
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEventsResponseIncompleteVariant2" /> class.
        /// </summary>
        public StreamEventsResponseIncompleteVariant2()
        {
        }

    }
}