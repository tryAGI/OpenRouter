
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A refusal before the stream opens. Once the response is `200` and streaming, failures arrive as a chunk with `finish_reason: "error"` instead.<br/>
    /// Example: {"error":{"code":409,"message":"That question is no longer waiting for an answer.","metadata":{"reason":"interaction_not_pending","retryable":false}}}
    /// </summary>
    public sealed partial class InternChatErrorResponse
    {
        /// <summary>
        /// The OpenAI-compatible error object. `metadata` is present on refusals from the chat route. Authentication refusals (`401`), the departed-creator `403` and the programme `404` carry only `code` and `message`.<br/>
        /// Example: {"code":409,"message":"That question is no longer waiting for an answer.","metadata":{"reason":"interaction_not_pending","retryable":false}}
        /// </summary>
        /// <example>{"code":409,"message":"That question is no longer waiting for an answer.","metadata":{"reason":"interaction_not_pending","retryable":false}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// The OpenAI-compatible error object. `metadata` is present on refusals from the chat route. Authentication refusals (`401`), the departed-creator `403` and the programme `404` carry only `code` and `message`.<br/>
        /// Example: {"code":409,"message":"That question is no longer waiting for an answer.","metadata":{"reason":"interaction_not_pending","retryable":false}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatErrorResponse(
            global::OpenRouter.InternChatError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatErrorResponse" /> class.
        /// </summary>
        public InternChatErrorResponse()
        {
        }

    }
}