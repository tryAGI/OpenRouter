
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Code interpreter tool configuration
    /// </summary>
    public sealed partial class CodeInterpreterServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolTypeJsonConverter))]
        public global::OpenRouter.CodeInterpreterServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CodeInterpreterServerToolContainer Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="container"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterServerTool(
            global::OpenRouter.CodeInterpreterServerToolContainer container,
            global::OpenRouter.CodeInterpreterServerToolType type)
        {
            this.Container = container;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterServerTool" /> class.
        /// </summary>
        public CodeInterpreterServerTool()
        {
        }
    }
}