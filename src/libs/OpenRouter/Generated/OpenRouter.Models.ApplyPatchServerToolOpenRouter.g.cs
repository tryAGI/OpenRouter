
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: validates V4A diff patches for file operations (create, update, delete). Restricted to the Responses API.
    /// </summary>
    public sealed partial class ApplyPatchServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for the openrouter:apply_patch server tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.ApplyPatchServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.ApplyPatchServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:apply_patch server tool
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchServerToolOpenRouter(
            global::OpenRouter.ApplyPatchServerToolConfig? parameters,
            global::OpenRouter.ApplyPatchServerToolOpenRouterType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerToolOpenRouter" /> class.
        /// </summary>
        public ApplyPatchServerToolOpenRouter()
        {
        }

    }
}