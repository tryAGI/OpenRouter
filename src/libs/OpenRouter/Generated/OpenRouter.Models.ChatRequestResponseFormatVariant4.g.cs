
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Python code response format
    /// </summary>
    public sealed partial class ChatRequestResponseFormatVariant4
    {
        /// <summary>
        /// Discriminator value: python
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant4TypeJsonConverter))]
        public global::OpenRouter.ChatRequestResponseFormatVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestResponseFormatVariant4" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: python
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestResponseFormatVariant4(
            global::OpenRouter.ChatRequestResponseFormatVariant4Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestResponseFormatVariant4" /> class.
        /// </summary>
        public ChatRequestResponseFormatVariant4()
        {
        }
    }
}