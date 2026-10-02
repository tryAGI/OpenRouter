
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The message was delivered into the turn already running on the same session. Its effect is streamed on that turn, not here.<br/>
    /// Example: {"session_id":"sess_01j9x0k4q7v8r2t3m6n5p8w9y1","status":"steered"}
    /// </summary>
    public sealed partial class InternChatSteeredResponse
    {
        /// <summary>
        /// The session of the running turn the message was delivered to.<br/>
        /// Example: sess_01j9x0k4q7v8r2t3m6n5p8w9y1
        /// </summary>
        /// <example>sess_01j9x0k4q7v8r2t3m6n5p8w9y1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The message was handed to the turn already running on this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatSteeredResponseStatusJsonConverter))]
        public global::OpenRouter.InternChatSteeredResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatSteeredResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The session of the running turn the message was delivered to.<br/>
        /// Example: sess_01j9x0k4q7v8r2t3m6n5p8w9y1
        /// </param>
        /// <param name="status">
        /// The message was handed to the turn already running on this session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatSteeredResponse(
            string sessionId,
            global::OpenRouter.InternChatSteeredResponseStatus status)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatSteeredResponse" /> class.
        /// </summary>
        public InternChatSteeredResponse()
        {
        }

    }
}