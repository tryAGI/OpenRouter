
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// thinking variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant10
    {
        /// <summary>
        /// Discriminator value: thinking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant10TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant10Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant10" /> class.
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="thinking"></param>
        /// <param name="type">
        /// Discriminator value: thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant10(
            string signature,
            string thinking,
            global::OpenRouter.ORAnthropicContentBlockVariant10Type type)
        {
            this.Type = type;
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant10" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant10()
        {
        }

    }
}