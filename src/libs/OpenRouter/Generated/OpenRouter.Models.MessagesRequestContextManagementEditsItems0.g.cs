
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_at_least")]
        public global::OpenRouter.AnthropicInputTokensClearAtLeast? ClearAtLeast { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tool_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs? ClearToolInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_tools")]
        public global::System.Collections.Generic.IList<string>? ExcludeTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        public global::OpenRouter.AnthropicToolUsesKeep? Keep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger? Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems0" /> class.
        /// </summary>
        /// <param name="clearAtLeast"></param>
        /// <param name="clearToolInputs"></param>
        /// <param name="excludeTools"></param>
        /// <param name="keep"></param>
        /// <param name="trigger"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItems0(
            global::OpenRouter.AnthropicInputTokensClearAtLeast? clearAtLeast,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs? clearToolInputs,
            global::System.Collections.Generic.IList<string>? excludeTools,
            global::OpenRouter.AnthropicToolUsesKeep? keep,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger? trigger,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type type)
        {
            this.ClearAtLeast = clearAtLeast;
            this.ClearToolInputs = clearToolInputs;
            this.ExcludeTools = excludeTools;
            this.Keep = keep;
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems0" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItems0()
        {
        }
    }
}