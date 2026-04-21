
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider-specific passthrough configuration
    /// </summary>
    public sealed partial class SpeechRequestProvider
    {
        /// <summary>
        /// Provider-specific options keyed by provider slug. The options for the matched provider are spread into the upstream request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::OpenRouter.SpeechRequestProviderOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequestProvider" /> class.
        /// </summary>
        /// <param name="options">
        /// Provider-specific options keyed by provider slug. The options for the matched provider are spread into the upstream request body.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequestProvider(
            global::OpenRouter.SpeechRequestProviderOptions? options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequestProvider" /> class.
        /// </summary>
        public SpeechRequestProvider()
        {
        }
    }
}