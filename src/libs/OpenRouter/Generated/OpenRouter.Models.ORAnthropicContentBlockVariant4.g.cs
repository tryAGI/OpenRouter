
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// compaction variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant4
    {
        /// <summary>
        /// Discriminator value: compaction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant4TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant4" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: compaction
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant4(
            global::OpenRouter.ORAnthropicContentBlockVariant4Type type,
            string? content)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant4" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant4()
        {
        }

    }
}