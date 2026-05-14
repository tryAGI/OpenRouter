
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant8
    {
        /// <summary>
        /// Discriminator value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant8TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant8Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant8" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Discriminator value: text
        /// </param>
        /// <param name="citations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant8(
            string text,
            global::OpenRouter.ORAnthropicContentBlockVariant8Type type,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>? citations)
        {
            this.Type = type;
            this.Citations = citations;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant8" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant8()
        {
        }

    }
}