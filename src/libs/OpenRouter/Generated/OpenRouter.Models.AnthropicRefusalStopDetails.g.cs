
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Structured information about a refusal
    /// </summary>
    public sealed partial class AnthropicRefusalStopDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AnthropicRefusalStopDetailsCategory?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.AnthropicRefusalStopDetailsCategory?, object> Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsTypeJsonConverter))]
        public global::OpenRouter.AnthropicRefusalStopDetailsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicRefusalStopDetails" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="explanation"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicRefusalStopDetails(
            global::OpenRouter.OneOf<global::OpenRouter.AnthropicRefusalStopDetailsCategory?, object> category,
            string? explanation,
            global::OpenRouter.AnthropicRefusalStopDetailsType type)
        {
            this.Category = category;
            this.Explanation = explanation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicRefusalStopDetails" /> class.
        /// </summary>
        public AnthropicRefusalStopDetails()
        {
        }
    }
}