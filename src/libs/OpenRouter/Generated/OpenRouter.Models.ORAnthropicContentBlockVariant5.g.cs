
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// redacted_thinking variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant5
    {
        /// <summary>
        /// Discriminator value: redacted_thinking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant5TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant5" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// Discriminator value: redacted_thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant5(
            string data,
            global::OpenRouter.ORAnthropicContentBlockVariant5Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant5" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant5()
        {
        }
    }
}