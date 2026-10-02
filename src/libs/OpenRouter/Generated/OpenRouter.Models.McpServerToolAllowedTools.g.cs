
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpServerToolAllowedTools
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolAllowedTools" /> class.
        /// </summary>
        /// <param name="readOnly"></param>
        /// <param name="toolNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerToolAllowedTools(
            bool? readOnly,
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ReadOnly = readOnly;
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolAllowedTools" /> class.
        /// </summary>
        public McpServerToolAllowedTools()
        {
        }

    }
}