
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesContentBlockDeltaEventDeltaVariant6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockDeltaEventDeltaVariant6TypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant6" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockDeltaEventDeltaVariant6(
            string? content,
            string? encryptedContent,
            global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6Type type)
        {
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant6" /> class.
        /// </summary>
        public MessagesContentBlockDeltaEventDeltaVariant6()
        {
        }

    }
}