
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeInterpreterServerToolContainer1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>? MemoryLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeJsonConverter))]
        public global::OpenRouter.CodeInterpreterServerToolContainerOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerToolContainer1" /> class.
        /// </summary>
        /// <param name="fileIds"></param>
        /// <param name="memoryLimit"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterServerToolContainer1(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::OpenRouter.OneOf<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>? memoryLimit,
            global::OpenRouter.CodeInterpreterServerToolContainerOneOf1Type type)
        {
            this.FileIds = fileIds;
            this.MemoryLimit = memoryLimit;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerToolContainer1" /> class.
        /// </summary>
        public CodeInterpreterServerToolContainer1()
        {
        }
    }
}