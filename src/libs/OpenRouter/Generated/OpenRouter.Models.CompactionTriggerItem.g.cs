
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Asks the model to compact the preceding input into a compaction item<br/>
    /// Example: {"type":"compaction_trigger"}
    /// </summary>
    public sealed partial class CompactionTriggerItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CompactionTriggerItemTypeJsonConverter))]
        public global::OpenRouter.CompactionTriggerItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionTriggerItem" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionTriggerItem(
            global::OpenRouter.CompactionTriggerItemType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionTriggerItem" /> class.
        /// </summary>
        public CompactionTriggerItem()
        {
        }

    }
}