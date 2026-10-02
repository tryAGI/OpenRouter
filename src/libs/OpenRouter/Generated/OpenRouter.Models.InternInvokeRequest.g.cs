
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A prompt to run on the intern without holding a connection open.<br/>
    /// Example: {"input":"New support ticket 48213. Case token: ct_9f2c. Investigate and reply."}
    /// </summary>
    public sealed partial class InternInvokeRequest
    {
        /// <summary>
        /// The prompt for the run, at most 32000 characters.<br/>
        /// Example: New support ticket 48213. Case token: ct_9f2c. Investigate and reply.
        /// </summary>
        /// <example>New support ticket 48213. Case token: ct_9f2c. Investigate and reply.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The session to run in. Send the `session_id` from an earlier `202` to continue that conversation, for example to hand the intern a decision on a case it is working. Omit it to start a new session. Only a `session_id` this endpoint issued to the same caller on the same intern is accepted; any other is refused with `404`.<br/>
        /// Example: b51a0e21-368b-4780-a220-14655bf28c55
        /// </summary>
        /// <example>b51a0e21-368b-4780-a220-14655bf28c55</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternInvokeRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The prompt for the run, at most 32000 characters.<br/>
        /// Example: New support ticket 48213. Case token: ct_9f2c. Investigate and reply.
        /// </param>
        /// <param name="sessionId">
        /// The session to run in. Send the `session_id` from an earlier `202` to continue that conversation, for example to hand the intern a decision on a case it is working. Omit it to start a new session. Only a `session_id` this endpoint issued to the same caller on the same intern is accepted; any other is refused with `404`.<br/>
        /// Example: b51a0e21-368b-4780-a220-14655bf28c55
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternInvokeRequest(
            string input,
            string? sessionId)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternInvokeRequest" /> class.
        /// </summary>
        public InternInvokeRequest()
        {
        }

    }
}