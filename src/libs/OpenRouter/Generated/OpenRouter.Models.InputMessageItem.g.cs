
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputMessageItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.InputMessageItemContentItems>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputMessageItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputMessageItemRole Role { get; set; }

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
            global::OpenRouter.InputMessageItemRole role,
            global::System.Collections.Generic.IList<global::OpenRouter.InputMessageItemContentItems>? content,
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