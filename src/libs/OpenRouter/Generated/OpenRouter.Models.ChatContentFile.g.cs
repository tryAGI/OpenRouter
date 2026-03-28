
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// File content part for document processing
    /// </summary>
    public sealed partial class ChatContentFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentFileTypeJsonConverter))]
        public global::OpenRouter.ChatContentFileType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatContentFileFile File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentFile" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="file"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentFile(
            global::OpenRouter.ChatContentFileFile file,
            global::OpenRouter.ChatContentFileType type)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentFile" /> class.
        /// </summary>
        public ChatContentFile()
        {
        }
    }
}