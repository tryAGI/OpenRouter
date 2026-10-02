
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":[{"text":"Hello, how are you?","type":"input_text"}],"id":"msg-abc123","role":"user","type":"message"}
    /// </summary>
    public sealed partial class InputMessageItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.InputMessageItemRoleVariant1?, global::OpenRouter.InputMessageItemRoleVariant2?, global::OpenRouter.InputMessageItemRoleVariant3?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.InputMessageItemRoleVariant1?, global::OpenRouter.InputMessageItemRoleVariant2?, global::OpenRouter.InputMessageItemRoleVariant3?> Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputMessageItemTypeJsonConverter))]
        public global::OpenRouter.InputMessageItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageItem" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMessageItem(
            global::OpenRouter.AnyOf<global::OpenRouter.InputMessageItemRoleVariant1?, global::OpenRouter.InputMessageItemRoleVariant2?, global::OpenRouter.InputMessageItemRoleVariant3?> role,
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? content,
            string? id,
            global::OpenRouter.InputMessageItemType? type)
        {
            this.Content = content;
            this.Id = id;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageItem" /> class.
        /// </summary>
        public InputMessageItem()
        {
        }

    }
}