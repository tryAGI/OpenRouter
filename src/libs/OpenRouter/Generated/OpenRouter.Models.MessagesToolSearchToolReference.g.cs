
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The name of one tool a tool search found.<br/>
    /// Example: {"tool_name":"get_weather","type":"tool_reference"}
    /// </summary>
    public sealed partial class MessagesToolSearchToolReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolSearchToolReferenceTypeJsonConverter))]
        public global::OpenRouter.MessagesToolSearchToolReferenceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolReference" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolSearchToolReference(
            string toolName,
            global::OpenRouter.MessagesToolSearchToolReferenceType type)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolReference" /> class.
        /// </summary>
        public MessagesToolSearchToolReference()
        {
        }

    }
}