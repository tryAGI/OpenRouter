
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Custom grammar response format
    /// </summary>
    public sealed partial class ChatRequestResponseFormatVariant1
    {
        /// <summary>
        /// Discriminator value: grammar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant1TypeJsonConverter))]
        public global::OpenRouter.ChatRequestResponseFormatVariant1Type Type { get; set; }

        /// <summary>
        /// Custom grammar for text generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grammar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestResponseFormatVariant1" /> class.
        /// </summary>
        /// <param name="grammar">
        /// Custom grammar for text generation
        /// </param>
        /// <param name="type">
        /// Discriminator value: grammar
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestResponseFormatVariant1(
            string grammar,
            global::OpenRouter.ChatRequestResponseFormatVariant1Type type)
        {
            this.Type = type;
            this.Grammar = grammar ?? throw new global::System.ArgumentNullException(nameof(grammar));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestResponseFormatVariant1" /> class.
        /// </summary>
        public ChatRequestResponseFormatVariant1()
        {
        }
    }
}