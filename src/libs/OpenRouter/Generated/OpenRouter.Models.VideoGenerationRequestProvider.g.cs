
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider-specific passthrough configuration
    /// </summary>
    public sealed partial class VideoGenerationRequestProvider
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ProviderOptions, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequestProvider(
            global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? options)
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