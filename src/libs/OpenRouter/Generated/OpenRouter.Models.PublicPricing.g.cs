
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Pricing information for the model
    /// </summary>
    public sealed partial class PublicPricing
    {
        /// <summary>
        /// Price in USD per audio input token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Price in USD per audio output token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_output")]
        public string? AudioOutput { get; set; }

        /// <summary>
        /// Price in USD per token for completion (output) generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// Fractional discount applied to this endpoint's pricing; the price is multiplied by (1 - discount) (0 = no discount, 1 = free)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Price in USD per input image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Price in USD per output image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_output")]
        public string? ImageOutput { get; set; }

        /// <summary>
        /// Price in USD per image token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        public string? ImageToken { get; set; }

        /// <summary>
        /// Price in USD per cached audio input token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public string? InputAudioCache { get; set; }

        /// <summary>
        /// Price in USD per cached input token (read)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public string? InputCacheRead { get; set; }

        /// <summary>
        /// Price in USD per cached input token (write)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public string? InputCacheWrite { get; set; }

        /// <summary>
        /// Price in USD per internal reasoning token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reasoning")]
        public string? InternalReasoning { get; set; }

        /// <summary>
        /// Price in USD per token for prompt (input) processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Price in USD per request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public string? Request { get; set; }

        /// <summary>
        /// Price in USD per web search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public string? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        /// <param name="completion">
        /// Price in USD per token for completion (output) generation
        /// </param>
        /// <param name="prompt">
        /// Price in USD per token for prompt (input) processing
        /// </param>
        /// <param name="audio">
        /// Price in USD per audio input token
        /// </param>
        /// <param name="audioOutput">
        /// Price in USD per audio output token
        /// </param>
        /// <param name="discount">
        /// Fractional discount applied to this endpoint's pricing; the price is multiplied by (1 - discount) (0 = no discount, 1 = free)
        /// </param>
        /// <param name="image">
        /// Price in USD per input image
        /// </param>
        /// <param name="imageOutput">
        /// Price in USD per output image
        /// </param>
        /// <param name="imageToken">
        /// Price in USD per image token
        /// </param>
        /// <param name="inputAudioCache">
        /// Price in USD per cached audio input token
        /// </param>
        /// <param name="inputCacheRead">
        /// Price in USD per cached input token (read)
        /// </param>
        /// <param name="inputCacheWrite">
        /// Price in USD per cached input token (write)
        /// </param>
        /// <param name="internalReasoning">
        /// Price in USD per internal reasoning token
        /// </param>
        /// <param name="request">
        /// Price in USD per request
        /// </param>
        /// <param name="webSearch">
        /// Price in USD per web search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicPricing(
            string completion,
            string prompt,
            string? audio,
            string? audioOutput,
            double? discount,
            string? image,
            string? imageOutput,
            string? imageToken,
            string? inputAudioCache,
            string? inputCacheRead,
            string? inputCacheWrite,
            string? internalReasoning,
            string? request,
            string? webSearch)
        {
            this.Audio = audio;
            this.AudioOutput = audioOutput;
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Discount = discount;
            this.Image = image;
            this.ImageOutput = imageOutput;
            this.ImageToken = imageToken;
            this.InputAudioCache = inputAudioCache;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.InternalReasoning = internalReasoning;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Request = request;
            this.WebSearch = webSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        public PublicPricing()
        {
        }

    }
}