
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
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenRouter.PublicPricingAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_output")]
        public global::OpenRouter.PublicPricingAudioOutput? AudioOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PublicPricingCompletion Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::OpenRouter.PublicPricingImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_output")]
        public global::OpenRouter.PublicPricingImageOutput? ImageOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        public global::OpenRouter.PublicPricingImageToken? ImageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public global::OpenRouter.PublicPricingInputAudioCache? InputAudioCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public global::OpenRouter.PublicPricingInputCacheRead? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public global::OpenRouter.PublicPricingInputCacheWrite? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reasoning")]
        public global::OpenRouter.PublicPricingInternalReasoning? InternalReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PublicPricingPrompt Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::OpenRouter.PublicPricingRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public global::OpenRouter.PublicPricingWebSearch? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPricing" /> class.
        /// </summary>
        /// <param name="completion"></param>
        /// <param name="prompt"></param>
        /// <param name="audio"></param>
        /// <param name="audioOutput"></param>
        /// <param name="discount"></param>
        /// <param name="image"></param>
        /// <param name="imageOutput"></param>
        /// <param name="imageToken"></param>
        /// <param name="inputAudioCache"></param>
        /// <param name="inputCacheRead"></param>
        /// <param name="inputCacheWrite"></param>
        /// <param name="internalReasoning"></param>
        /// <param name="request"></param>
        /// <param name="webSearch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicPricing(
            global::OpenRouter.PublicPricingCompletion completion,
            global::OpenRouter.PublicPricingPrompt prompt,
            global::OpenRouter.PublicPricingAudio? audio,
            global::OpenRouter.PublicPricingAudioOutput? audioOutput,
            double? discount,
            global::OpenRouter.PublicPricingImage? image,
            global::OpenRouter.PublicPricingImageOutput? imageOutput,
            global::OpenRouter.PublicPricingImageToken? imageToken,
            global::OpenRouter.PublicPricingInputAudioCache? inputAudioCache,
            global::OpenRouter.PublicPricingInputCacheRead? inputCacheRead,
            global::OpenRouter.PublicPricingInputCacheWrite? inputCacheWrite,
            global::OpenRouter.PublicPricingInternalReasoning? internalReasoning,
            global::OpenRouter.PublicPricingRequest? request,
            global::OpenRouter.PublicPricingWebSearch? webSearch)
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