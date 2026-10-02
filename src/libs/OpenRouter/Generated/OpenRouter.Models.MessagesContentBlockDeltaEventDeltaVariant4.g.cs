
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesContentBlockDeltaEventDeltaVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockDeltaEventDeltaVariant4TypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant4" /> class.
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockDeltaEventDeltaVariant4(
            string signature,
            global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4Type type)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant4" /> class.
        /// </summary>
        public MessagesContentBlockDeltaEventDeltaVariant4()
        {
        }

    }
}