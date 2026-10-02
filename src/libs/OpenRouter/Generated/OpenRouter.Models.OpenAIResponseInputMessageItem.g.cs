
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":[{"text":"Hello, how are you?","type":"input_text"}],"id":"msg-abc123","role":"user","type":"message"}
    /// </summary>
    public sealed partial class OpenAIResponseInputMessageItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ContentItem4> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant1?, global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant2?, global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant3?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant1?, global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant2?, global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant3?> Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponseInputMessageItemTypeJsonConverter))]
        public global::OpenRouter.OpenAIResponseInputMessageItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseInputMessageItem" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponseInputMessageItem(
            global::System.Collections.Generic.IList<global::OpenRouter.ContentItem4> content,
            string id,
            global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant1?, global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant2?, global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant3?> role,
            global::OpenRouter.OpenAIResponseInputMessageItemType? type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseInputMessageItem" /> class.
        /// </summary>
        public OpenAIResponseInputMessageItem()
        {
        }

    }
}