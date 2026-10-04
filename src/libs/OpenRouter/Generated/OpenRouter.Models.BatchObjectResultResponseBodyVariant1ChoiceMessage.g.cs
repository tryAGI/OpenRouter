
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2, global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3>>? Annotations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage>? Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_details")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>?>? ReasoningDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant1ChoiceMessageRoleJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessage" /> class.
        /// </summary>
        /// <param name="annotations"></param>
        /// <param name="content"></param>
        /// <param name="images"></param>
        /// <param name="reasoning"></param>
        /// <param name="reasoningDetails"></param>
        /// <param name="refusal"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceMessage(
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2, global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3>>? annotations,
            string? content,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage>? images,
            string? reasoning,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>?>? reasoningDetails,
            string? refusal,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageRole role,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall>? toolCalls)
        {
            this.Annotations = annotations;
            this.Content = content;
            this.Images = images;
            this.Reasoning = reasoning;
            this.ReasoningDetails = reasoningDetails;
            this.Refusal = refusal;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessage" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceMessage()
        {
        }

    }
}