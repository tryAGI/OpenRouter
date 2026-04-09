
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output from a function call execution
    /// </summary>
    public sealed partial class FunctionCallOutputItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FunctionCallOutputItemOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputTypeJsonConverter))]
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallOutputItem(
            string callId,
            global::OpenRouter.FunctionCallOutputItemOutput output,
            string? id,
            global::OpenRouter.OpenAiResponseFunctionToolCallOutputStatus? status,
            global::OpenRouter.OpenAiResponseFunctionToolCallOutputType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Output = output;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItem" /> class.
        /// </summary>
        public FunctionCallOutputItem()
        {
        }
    }
}