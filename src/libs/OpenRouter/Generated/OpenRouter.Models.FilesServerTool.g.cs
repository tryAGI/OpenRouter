
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: read, write, edit, and list workspace files via the Files API. Requires the `x-openrouter-file-ids: openrouter` request header.
    /// </summary>
    public sealed partial class FilesServerTool
    {
        /// <summary>
        /// Configuration for the openrouter:files server tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.FilesServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FilesServerToolTypeJsonConverter))]
        public global::OpenRouter.FilesServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:files server tool
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesServerTool(
            global::OpenRouter.FilesServerToolConfig? parameters,
            global::OpenRouter.FilesServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesServerTool" /> class.
        /// </summary>
        public FilesServerTool()
        {
        }

    }
}