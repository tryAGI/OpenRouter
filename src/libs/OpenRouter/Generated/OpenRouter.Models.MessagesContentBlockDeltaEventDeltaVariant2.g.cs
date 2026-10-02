
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesContentBlockDeltaEventDeltaVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialJson { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockDeltaEventDeltaVariant2TypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant2" /> class.
        /// </summary>
        /// <param name="partialJson"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockDeltaEventDeltaVariant2(
            string partialJson,
            global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2Type type)
        {
            this.PartialJson = partialJson ?? throw new global::System.ArgumentNullException(nameof(partialJson));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEventDeltaVariant2" /> class.
        /// </summary>
        public MessagesContentBlockDeltaEventDeltaVariant2()
        {
        }

    }
}