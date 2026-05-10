
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// code_execution_20250825 variant
    /// </summary>
    public sealed partial class AnthropicCallerVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecution20250825CallerTypeJsonConverter))]
        public global::OpenRouter.AnthropicCodeExecution20250825CallerType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCallerVariant1" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicCallerVariant1(
            string toolId,
            global::OpenRouter.AnthropicCodeExecution20250825CallerType type)
        {
            this.Type = type;
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCallerVariant1" /> class.
        /// </summary>
        public AnthropicCallerVariant1()
        {
        }

    }
}