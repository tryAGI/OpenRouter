
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIResponsesToolChoiceVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1?, global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1?, global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2?> Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesToolChoiceVariant5" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponsesToolChoiceVariant5(
            global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1?, global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2?> type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesToolChoiceVariant5" /> class.
        /// </summary>
        public OpenAIResponsesToolChoiceVariant5()
        {
        }

    }
}