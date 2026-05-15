
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentPartInputFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MultimodalMedia InputFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentPartInputFileTypeJsonConverter))]
        public global::OpenRouter.ContentPartInputFileType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartInputFile" /> class.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPartInputFile(
            global::OpenRouter.MultimodalMedia inputFile,
            global::OpenRouter.ContentPartInputFileType type)
        {
            this.InputFile = inputFile ?? throw new global::System.ArgumentNullException(nameof(inputFile));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartInputFile" /> class.
        /// </summary>
        public ContentPartInputFile()
        {
        }

    }
}