
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider-specific passthrough configuration
    /// </summary>
    public sealed partial class VideoGenerationRequestProvider
    {
        /// <summary>
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::OpenRouter.VideoGenerationRequestProviderOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        /// <param name="options">
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequestProvider(
            global::OpenRouter.VideoGenerationRequestProviderOptions? options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        public VideoGenerationRequestProvider()
        {
        }

    }
}