
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text input content item
    /// </summary>
    public sealed partial class FunctionCallOutputItemOutputOneOf1ItemsVariant3
    {
        /// <summary>
        /// Discriminator value: input_text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant3TypeJsonConverter))]
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemOutputOneOf1ItemsVariant3" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Discriminator value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallOutputItemOutputOneOf1ItemsVariant3(
            string text,
            global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3Type type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemOutputOneOf1ItemsVariant3" /> class.
        /// </summary>
        public FunctionCallOutputItemOutputOneOf1ItemsVariant3()
        {
        }

    }
}