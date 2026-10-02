
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorTypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator(
            global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator" /> class.
        /// </summary>
        public MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator()
        {
        }

    }
}