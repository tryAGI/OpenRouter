
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output from a custom (freeform-grammar) tool call execution. Mirrors `function_call_output` but is matched to a `custom_tool_call` rather than a `function_call`.
    /// </summary>
    public sealed partial class CustomToolCallOutputItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CustomToolCallOutputItemOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CustomToolCallOutputItemOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CustomToolCallOutputItemTypeJsonConverter))]
        public global::OpenRouter.CustomToolCallOutputItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolCallOutputItem(
            string callId,
            global::OpenRouter.CustomToolCallOutputItemOutput output,
            string? id,
            global::OpenRouter.CustomToolCallOutputItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Output = output;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolCallOutputItem" /> class.
        /// </summary>
        public CustomToolCallOutputItem()
        {
        }
    }
}