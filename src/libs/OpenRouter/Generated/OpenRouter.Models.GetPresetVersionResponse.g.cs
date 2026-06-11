
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single version of a preset.
    /// </summary>
    public sealed partial class GetPresetVersionResponse
    {
        /// <summary>
        /// A specific version of a preset, containing config and optional system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PresetDesignatedVersion Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresetVersionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A specific version of a preset, containing config and optional system prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPresetVersionResponse(
            global::OpenRouter.PresetDesignatedVersion data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresetVersionResponse" /> class.
        /// </summary>
        public GetPresetVersionResponse()
        {
        }

    }
}