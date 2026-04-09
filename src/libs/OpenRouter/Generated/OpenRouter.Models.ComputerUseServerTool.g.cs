
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Computer use preview tool configuration
    /// </summary>
    public sealed partial class ComputerUseServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ComputerUseServerToolEnvironment Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolTypeJsonConverter))]
        public global::OpenRouter.ComputerUseServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseServerTool" /> class.
        /// </summary>
        /// <param name="displayHeight"></param>
        /// <param name="displayWidth"></param>
        /// <param name="environment"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerUseServerTool(
            int displayHeight,
            int displayWidth,
            global::OpenRouter.ComputerUseServerToolEnvironment environment,
            global::OpenRouter.ComputerUseServerToolType type)
        {
            this.DisplayHeight = displayHeight;
            this.DisplayWidth = displayWidth;
            this.Environment = environment;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseServerTool" /> class.
        /// </summary>
        public ComputerUseServerTool()
        {
        }
    }
}