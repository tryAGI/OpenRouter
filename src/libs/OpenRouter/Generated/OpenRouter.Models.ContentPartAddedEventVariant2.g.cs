
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContentPartAddedEventVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.ResponseOutputText, global::OpenRouter.ReasoningTextContent, global::OpenRouter.OpenAIResponsesRefusalContent>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.ReasoningTextContent, global::OpenRouter.OpenAIResponsesRefusalContent>? Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartAddedEventVariant2" /> class.
        /// </summary>
        /// <param name="part"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPartAddedEventVariant2(
            global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.ReasoningTextContent, global::OpenRouter.OpenAIResponsesRefusalContent>? part)
        {
            this.Part = part;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartAddedEventVariant2" /> class.
        /// </summary>
        public ContentPartAddedEventVariant2()
        {
        }

    }
}