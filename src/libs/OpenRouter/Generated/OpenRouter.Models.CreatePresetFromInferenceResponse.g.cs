
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Response containing the created preset with its designated version.
    /// </summary>
    public sealed partial class CreatePresetFromInferenceResponse
    {
        /// <summary>
        /// A preset with its currently designated version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PresetWithDesignatedVersion Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePresetFromInferenceResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A preset with its currently designated version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePresetFromInferenceResponse(
            global::OpenRouter.PresetWithDesignatedVersion data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePresetFromInferenceResponse" /> class.
        /// </summary>
        public CreatePresetFromInferenceResponse()
        {
        }

    }
}