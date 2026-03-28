
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Local shell tool configuration
    /// </summary>
    public sealed partial class CodexLocalShellTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodexLocalShellToolTypeJsonConverter))]
        public global::OpenRouter.CodexLocalShellToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodexLocalShellTool" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodexLocalShellTool(
            global::OpenRouter.CodexLocalShellToolType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodexLocalShellTool" /> class.
        /// </summary>
        public CodexLocalShellTool()
        {
        }
    }
}