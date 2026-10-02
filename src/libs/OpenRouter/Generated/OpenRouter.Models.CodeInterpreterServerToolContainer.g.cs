
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeInterpreterServerToolContainer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerMemoryLimitJsonConverter))]
        public global::OpenRouter.CodeInterpreterServerToolContainerMemoryLimit? MemoryLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerTypeJsonConverter))]
        public global::OpenRouter.CodeInterpreterServerToolContainerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerToolContainer" /> class.
        /// </summary>
        /// <param name="fileIds"></param>
        /// <param name="memoryLimit"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterServerToolContainer(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::OpenRouter.CodeInterpreterServerToolContainerMemoryLimit? memoryLimit,
            global::OpenRouter.CodeInterpreterServerToolContainerType type)
        {
            this.FileIds = fileIds;
            this.MemoryLimit = memoryLimit;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerToolContainer" /> class.
        /// </summary>
        public CodeInterpreterServerToolContainer()
        {
        }

    }
}