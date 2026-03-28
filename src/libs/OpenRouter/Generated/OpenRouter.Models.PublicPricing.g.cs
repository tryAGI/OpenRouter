
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Pricing information for the model
    /// </summary>
    public sealed partial class PublicPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public object? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public object? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        public object? ImageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_output")]
        public object? ImageOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public object? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_output")]
        public object? AudioOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public object? InputAudioCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public object? WebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reasoning")]
        public object? InternalReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public object? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public object? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="completion"></param>
        /// <param name="request"></param>
        /// <param name="image"></param>
        /// <param name="imageToken"></param>
        /// <param name="imageOutput"></param>
        /// <param name="audio"></param>
        /// <param name="audioOutput"></param>
        /// <param name="inputAudioCache"></param>
        /// <param name="webSearch"></param>
        /// <param name="internalReasoning"></param>
        /// <param name="inputCacheRead"></param>
        /// <param name="inputCacheWrite"></param>
        /// <param name="discount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicPricing(
            object prompt,
            object completion,
            object? request,
            object? image,
            object? imageToken,
            object? imageOutput,
            object? audio,
            object? audioOutput,
            object? inputAudioCache,
            object? webSearch,
            object? internalReasoning,
            object? inputCacheRead,
            object? inputCacheWrite,
            double? discount)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Request = request;
            this.Image = image;
            this.ImageToken = imageToken;
            this.ImageOutput = imageOutput;
            this.Audio = audio;
            this.AudioOutput = audioOutput;
            this.InputAudioCache = inputAudioCache;
            this.WebSearch = webSearch;
            this.InternalReasoning = internalReasoning;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.Discount = discount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        public PublicPricing()
        {
        }
    }
}