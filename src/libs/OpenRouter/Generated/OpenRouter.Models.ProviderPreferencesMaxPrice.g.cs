
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
    /// </summary>
    public sealed partial class ProviderPreferencesMaxPrice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenRouter.ProviderPreferencesMaxPriceAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public global::OpenRouter.ProviderPreferencesMaxPriceCompletion? Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::OpenRouter.ProviderPreferencesMaxPriceImage? Image { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::OpenRouter.ProviderPreferencesMaxPriceRequest? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderPreferencesMaxPrice" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="completion"></param>
        /// <param name="image"></param>
        /// <param name="prompt">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderPreferencesMaxPrice(
            global::OpenRouter.ProviderPreferencesMaxPriceAudio? audio,
            global::OpenRouter.ProviderPreferencesMaxPriceCompletion? completion,
            global::OpenRouter.ProviderPreferencesMaxPriceImage? image,
            string? prompt,
            global::OpenRouter.ProviderPreferencesMaxPriceRequest? request)
        {
            this.Audio = audio;
            this.Completion = completion;
            this.Image = image;
            this.Prompt = prompt;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderPreferencesMaxPrice" /> class.
        /// </summary>
        public ProviderPreferencesMaxPrice()
        {
        }
    }
}