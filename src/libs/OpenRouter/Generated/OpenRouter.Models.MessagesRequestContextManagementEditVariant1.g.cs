
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditVariant1
    {
        /// <summary>
        /// Example: {"type":"input_tokens","value":50000}
        /// </summary>
        /// <example>{"type":"input_tokens","value":50000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_at_least")]
        public global::OpenRouter.AnthropicInputTokensClearAtLeast? ClearAtLeast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tool_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>))]
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? ClearToolInputs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_tools")]
        public global::System.Collections.Generic.IList<string>? ExcludeTools { get; set; }

        /// <summary>
        /// Example: {"type":"tool_uses","value":5}
        /// </summary>
        /// <example>{"type":"tool_uses","value":5}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        public global::OpenRouter.AnthropicToolUsesKeep? Keep { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TriggerJsonConverter))]
        public global::OpenRouter.Trigger? Trigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditVariant1TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditVariant1" /> class.
        /// </summary>
        /// <param name="clearAtLeast">
        /// Example: {"type":"input_tokens","value":50000}
        /// </param>
        /// <param name="clearToolInputs"></param>
        /// <param name="excludeTools"></param>
        /// <param name="keep">
        /// Example: {"type":"tool_uses","value":5}
        /// </param>
        /// <param name="trigger"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditVariant1(
            global::OpenRouter.AnthropicInputTokensClearAtLeast? clearAtLeast,
            global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? clearToolInputs,
            global::System.Collections.Generic.IList<string>? excludeTools,
            global::OpenRouter.AnthropicToolUsesKeep? keep,
            global::OpenRouter.Trigger? trigger,
            global::OpenRouter.MessagesRequestContextManagementEditVariant1Type type)
        {
            this.ClearAtLeast = clearAtLeast;
            this.ClearToolInputs = clearToolInputs;
            this.ExcludeTools = excludeTools;
            this.Keep = keep;
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditVariant1" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditVariant1()
        {
        }

    }
}