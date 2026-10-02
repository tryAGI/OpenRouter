
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The intern admitted the prompt. The run continues on the intern.<br/>
    /// Example: {"session_id":"b51a0e21-368b-4780-a220-14655bf28c55","status":"started"}
    /// </summary>
    public sealed partial class InternInvokeAcceptedResponse
    {
        /// <summary>
        /// The session the run belongs to. Send it back to continue the conversation.<br/>
        /// Example: b51a0e21-368b-4780-a220-14655bf28c55
        /// </summary>
        /// <example>b51a0e21-368b-4780-a220-14655bf28c55</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// `started` when a new run began. `steered` when the session already had a run going and the prompt was delivered into it instead.<br/>
        /// Example: started
        /// </summary>
        /// <example>started</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternInvokeAcceptedResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternInvokeAcceptedResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternInvokeAcceptedResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The session the run belongs to. Send it back to continue the conversation.<br/>
        /// Example: b51a0e21-368b-4780-a220-14655bf28c55
        /// </param>
        /// <param name="status">
        /// `started` when a new run began. `steered` when the session already had a run going and the prompt was delivered into it instead.<br/>
        /// Example: started
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternInvokeAcceptedResponse(
            string sessionId,
            global::OpenRouter.InternInvokeAcceptedResponseStatus status)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternInvokeAcceptedResponse" /> class.
        /// </summary>
        public InternInvokeAcceptedResponse()
        {
        }

    }
}