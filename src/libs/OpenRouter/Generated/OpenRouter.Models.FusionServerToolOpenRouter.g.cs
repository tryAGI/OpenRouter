
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: fans out the user prompt to a panel of analysis models, then asks a judge model to summarize their collective output as structured JSON the outer model can synthesize from.
    /// </summary>
    public sealed partial class FusionServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for the openrouter:fusion server tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.FusionServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.FusionServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:fusion server tool.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionServerToolOpenRouter(
            global::OpenRouter.FusionServerToolConfig? parameters,
            global::OpenRouter.FusionServerToolOpenRouterType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolOpenRouter" /> class.
        /// </summary>
        public FusionServerToolOpenRouter()
        {
        }

    }
}