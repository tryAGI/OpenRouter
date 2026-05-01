
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// File content part for document processing
    /// </summary>
    public sealed partial class ChatContentItemsVariant1
    {
        /// <summary>
        /// Discriminator value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant1TypeJsonConverter))]
        public global::OpenRouter.ChatContentItemsVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatContentItemsDiscriminatorMappingFileFile File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentItemsVariant1" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type">
        /// Discriminator value: file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentItemsVariant1(
            global::OpenRouter.ChatContentItemsDiscriminatorMappingFileFile file,
            global::OpenRouter.ChatContentItemsVariant1Type type)
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentItemsVariant1" /> class.
        /// </summary>
        public ChatContentItemsVariant1()
        {
        }
    }
}