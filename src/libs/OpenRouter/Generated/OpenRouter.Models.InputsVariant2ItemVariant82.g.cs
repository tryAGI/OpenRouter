
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputsVariant2ItemVariant82
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string, object>))]
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string, object>? Content { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputsVariant2ItemVariant8TypeJsonConverter))]
        public global::OpenRouter.InputsVariant2ItemVariant8Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsVariant2ItemVariant82" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputsVariant2ItemVariant82(
            global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string, object>? content,
            global::OpenRouter.InputsVariant2ItemVariant8Type? type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsVariant2ItemVariant82" /> class.
        /// </summary>
        public InputsVariant2ItemVariant82()
        {
        }

    }
}