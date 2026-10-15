
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArmorSafeguardResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_uses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolUses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorSafeguardResultStatusTypeJsonConverter))]
        public global::OpenRouter.ArmorSafeguardResultStatusType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorSafeguardResultStatus" /> class.
        /// </summary>
        /// <param name="toolUses"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArmorSafeguardResultStatus(
            object toolUses,
            global::OpenRouter.ArmorSafeguardResultStatusType type)
        {
            this.ToolUses = toolUses ?? throw new global::System.ArgumentNullException(nameof(toolUses));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorSafeguardResultStatus" /> class.
        /// </summary>
        public ArmorSafeguardResultStatus()
        {
        }

    }
}