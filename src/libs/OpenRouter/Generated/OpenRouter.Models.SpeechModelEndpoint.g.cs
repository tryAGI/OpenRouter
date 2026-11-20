
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One endpoint serving a speech model, with the inputs and parameters it accepts.<br/>
    /// Example: {"input_modalities":[{"type":"text"}],"output_modalities":[{"supported_parameters":{"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}},"type":"speech"}],"provider_name":"OpenAI","provider_slug":"openai"}
    /// </summary>
    public sealed partial class SpeechModelEndpoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputModality> InputModalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.SpeechOutputModality> OutputModalities { get; set; }

        /// <summary>
        /// Provider display name<br/>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Provider slug<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechModelEndpoint" /> class.
        /// </summary>
        /// <param name="inputModalities"></param>
        /// <param name="outputModalities"></param>
        /// <param name="providerName">
        /// Provider display name<br/>
        /// Example: OpenAI
        /// </param>
        /// <param name="providerSlug">
        /// Provider slug<br/>
        /// Example: openai
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechModelEndpoint(
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputModality> inputModalities,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechOutputModality> outputModalities,
            string providerName,
            string providerSlug)
        {
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechModelEndpoint" /> class.
        /// </summary>
        public SpeechModelEndpoint()
        {
        }

    }
}