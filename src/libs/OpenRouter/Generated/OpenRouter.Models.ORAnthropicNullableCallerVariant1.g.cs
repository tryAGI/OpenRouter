
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// code_execution_20250825 variant
    /// </summary>
    public sealed partial class ORAnthropicNullableCallerVariant1
    {
        /// <summary>
        /// Discriminator value: code_execution_20250825
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicNullableCallerVariant1TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicNullableCallerVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ORAnthropicNullableCallerVariant1" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="type">
        /// Discriminator value: code_execution_20250825
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicNullableCallerVariant1(
            string toolId,
            global::OpenRouter.ORAnthropicNullableCallerVariant1Type type)
        {
            this.Type = type;
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicNullableCallerVariant1" /> class.
        /// </summary>
        public ORAnthropicNullableCallerVariant1()
        {
        }

    }
}