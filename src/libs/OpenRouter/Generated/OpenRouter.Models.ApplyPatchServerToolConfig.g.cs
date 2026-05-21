
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:apply_patch server tool
    /// </summary>
    public sealed partial class ApplyPatchServerToolConfig
    {
        /// <summary>
        /// Which apply_patch engine to use. "auto" (default) uses native passthrough when the endpoint advertises native apply_patch support, otherwise falls back to OpenRouter's HITL validator. "native" forces native passthrough — when the endpoint does not support native, the request falls back to HITL. "openrouter" always runs the HITL validator. Native passthrough streams the diff incrementally via `apply_patch_call_operation_diff.delta` events; HITL buffers the diff for atomic delivery as a single delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchEngineEnumJsonConverter))]
        public global::OpenRouter.ApplyPatchEngineEnum? Engine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerToolConfig" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which apply_patch engine to use. "auto" (default) uses native passthrough when the endpoint advertises native apply_patch support, otherwise falls back to OpenRouter's HITL validator. "native" forces native passthrough — when the endpoint does not support native, the request falls back to HITL. "openrouter" always runs the HITL validator. Native passthrough streams the diff incrementally via `apply_patch_call_operation_diff.delta` events; HITL buffers the diff for atomic delivery as a single delta.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchServerToolConfig(
            global::OpenRouter.ApplyPatchEngineEnum? engine)
        {
            this.Engine = engine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerToolConfig" /> class.
        /// </summary>
        public ApplyPatchServerToolConfig()
        {
        }

    }
}