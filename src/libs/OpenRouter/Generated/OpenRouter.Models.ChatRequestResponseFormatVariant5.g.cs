
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default text response format
    /// </summary>
    public sealed partial class ChatRequestResponseFormatVariant5
    {
        /// <summary>
        /// Discriminator value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant5TypeJsonConverter))]
        public global::OpenRouter.ChatRequestResponseFormatVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestResponseFormatVariant5" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestResponseFormatVariant5(
            global::OpenRouter.ChatRequestResponseFormatVariant5Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestResponseFormatVariant5" /> class.
        /// </summary>
        public ChatRequestResponseFormatVariant5()
        {
        }
    }
}