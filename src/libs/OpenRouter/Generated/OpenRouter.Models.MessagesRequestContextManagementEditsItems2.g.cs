
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItems2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_after_compaction")]
        public bool? PauseAfterCompaction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Trigger? Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems2" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="pauseAfterCompaction"></param>
        /// <param name="trigger"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItems2(
            string? instructions,
            bool? pauseAfterCompaction,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Trigger? trigger,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type type)
        {
            this.Instructions = instructions;
            this.PauseAfterCompaction = pauseAfterCompaction;
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems2" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItems2()
        {
        }
    }
}