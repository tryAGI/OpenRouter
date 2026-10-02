
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.AnthropicThinkingTurns, global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum, global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum2?>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.AnthropicThinkingTurns, global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum, global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum2?>? Keep { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditVariant2TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditVariant2" /> class.
        /// </summary>
        /// <param name="keep"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditVariant2(
            global::OpenRouter.AnyOf<global::OpenRouter.AnthropicThinkingTurns, global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum, global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum2?>? keep,
            global::OpenRouter.MessagesRequestContextManagementEditVariant2Type type)
        {
            this.Keep = keep;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditVariant2" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditVariant2()
        {
        }

    }
}