
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: runs shell commands server-side in a sandboxed container
    /// </summary>
    public sealed partial class BashServerTool
    {
        /// <summary>
        /// Configuration for the openrouter:bash server tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.BashServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BashServerToolTypeJsonConverter))]
        public global::OpenRouter.BashServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:bash server tool
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashServerTool(
            global::OpenRouter.BashServerToolConfig? parameters,
            global::OpenRouter.BashServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerTool" /> class.
        /// </summary>
        public BashServerTool()
        {
        }

    }
}