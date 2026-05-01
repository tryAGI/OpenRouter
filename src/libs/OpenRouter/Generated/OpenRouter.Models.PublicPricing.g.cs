
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Pricing information for the model
    /// </summary>
    public sealed partial class PublicPricing
    {
        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_output")]
        public string? AudioOutput { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_output")]
        public string? ImageOutput { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        public string? ImageToken { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public string? InputAudioCache { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public string? InputCacheRead { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public string? InputCacheWrite { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reasoning")]
        public string? InternalReasoning { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public string? Request { get; set; }

        /// <summary>
        /// Price per million prompt tokens
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
        /// Price per million prompt tokens
        /// </param>
        /// <param name="prompt">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="audio">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="audioOutput">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="discount"></param>
        /// <param name="image">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="imageOutput">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="imageToken">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="inputAudioCache">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="inputCacheRead">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="inputCacheWrite">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="internalReasoning">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="request">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="webSearch">
        /// Price per million prompt tokens
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