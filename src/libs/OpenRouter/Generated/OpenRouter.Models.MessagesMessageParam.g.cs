
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Anthropic message with OpenRouter extensions<br/>
    /// Example: {"content":"Hello, how are you?","role":"user"}
    /// </summary>
    public sealed partial class MessagesMessageParam
    {
        /// <summary>
        /// Example: next_user_message
        /// </summary>
        /// <example>next_user_message</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicSystemClearAtJsonConverter))]
        public global::OpenRouter.AnthropicSystemClearAt? ClearAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.AnthropicTextBlockParam, global::OpenRouter.AnthropicImageBlockParam, global::OpenRouter.AnthropicDocumentBlockParam, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9, global::OpenRouter.AnthropicSearchResultBlockParam, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11, global::OpenRouter.MessagesAdvisorToolResultBlock, global::OpenRouter.MessagesToolAdditionBlock, global::OpenRouter.MessagesToolRemovalBlock, global::OpenRouter.MessagesShellToolResultBlock, global::OpenRouter.MessagesBashToolResultBlock, global::OpenRouter.ORAnthropicToolSearchResultParam>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.AnthropicTextBlockParam, global::OpenRouter.AnthropicImageBlockParam, global::OpenRouter.AnthropicDocumentBlockParam, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9, global::OpenRouter.AnthropicSearchResultBlockParam, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11, global::OpenRouter.MessagesAdvisorToolResultBlock, global::OpenRouter.MessagesToolAdditionBlock, global::OpenRouter.MessagesToolRemovalBlock, global::OpenRouter.MessagesShellToolResultBlock, global::OpenRouter.MessagesBashToolResultBlock, global::OpenRouter.ORAnthropicToolSearchResultParam>>> Content { get; set; }

        /// <summary>
        /// Example: {"effort":"low"}
        /// </summary>
        /// <example>{"effort":"low"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::OpenRouter.AnthropicMessageOutputConfig? OutputConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesMessageParamRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="clearAt">
        /// Example: next_user_message
        /// </param>
        /// <param name="outputConfig">
        /// Example: {"effort":"low"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParam(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.AnthropicTextBlockParam, global::OpenRouter.AnthropicImageBlockParam, global::OpenRouter.AnthropicDocumentBlockParam, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9, global::OpenRouter.AnthropicSearchResultBlockParam, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11, global::OpenRouter.MessagesAdvisorToolResultBlock, global::OpenRouter.MessagesToolAdditionBlock, global::OpenRouter.MessagesToolRemovalBlock, global::OpenRouter.MessagesShellToolResultBlock, global::OpenRouter.MessagesBashToolResultBlock, global::OpenRouter.ORAnthropicToolSearchResultParam>>> content,
            global::OpenRouter.MessagesMessageParamRole role,
            global::OpenRouter.AnthropicSystemClearAt? clearAt,
            global::OpenRouter.AnthropicMessageOutputConfig? outputConfig)
        {
            this.ClearAt = clearAt;
            this.Content = content;
            this.OutputConfig = outputConfig;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParam" /> class.
        /// </summary>
        public MessagesMessageParam()
        {
        }

    }
}