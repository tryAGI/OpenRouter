
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditVariant3
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
        /// Example: {"type":"input_tokens","value":100000}
        /// </summary>
        /// <example>{"type":"input_tokens","value":100000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicInputTokensTrigger, object>? Trigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditVariant3TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditVariant3" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="pauseAfterCompaction"></param>
        /// <param name="trigger">
        /// Example: {"type":"input_tokens","value":100000}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditVariant3(
            string? instructions,
            bool? pauseAfterCompaction,
            global::OpenRouter.AllOf<global::OpenRouter.AnthropicInputTokensTrigger, object>? trigger,
            global::OpenRouter.MessagesRequestContextManagementEditVariant3Type type)
        {
            this.Instructions = instructions;
            this.PauseAfterCompaction = pauseAfterCompaction;
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditVariant3" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditVariant3()
        {
        }

    }
}