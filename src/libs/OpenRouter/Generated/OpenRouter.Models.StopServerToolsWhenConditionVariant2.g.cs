
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop after a tool with this name has been called.
    /// </summary>
    public sealed partial class StopServerToolsWhenConditionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenHasToolCallTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenHasToolCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenConditionVariant2" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenConditionVariant2(
            string toolName,
            global::OpenRouter.StopServerToolsWhenHasToolCallType type)
        {
            this.Type = type;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenConditionVariant2" /> class.
        /// </summary>
        public StopServerToolsWhenConditionVariant2()
        {
        }

    }
}