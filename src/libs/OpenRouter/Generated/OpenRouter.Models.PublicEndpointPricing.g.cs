
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicEndpointPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenRouter.PublicEndpointPricingAudio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_output")]
        public global::OpenRouter.PublicEndpointPricingAudioOutput? AudioOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PublicEndpointPricingCompletion Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::OpenRouter.PublicEndpointPricingImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_output")]
        public global::OpenRouter.PublicEndpointPricingImageOutput? ImageOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        public global::OpenRouter.PublicEndpointPricingImageToken? ImageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public global::OpenRouter.PublicEndpointPricingInputAudioCache? InputAudioCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public global::OpenRouter.PublicEndpointPricingInputCacheRead? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public global::OpenRouter.PublicEndpointPricingInputCacheWrite? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_reasoning")]
        public global::OpenRouter.PublicEndpointPricingInternalReasoning? InternalReasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PublicEndpointPricingPrompt Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::OpenRouter.PublicEndpointPricingRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public global::OpenRouter.PublicEndpointPricingWebSearch? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointPricing" /> class.
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
        public PublicEndpointPricing(
            global::OpenRouter.PublicEndpointPricingCompletion completion,
            global::OpenRouter.PublicEndpointPricingPrompt prompt,
            global::OpenRouter.PublicEndpointPricingAudio? audio,
            global::OpenRouter.PublicEndpointPricingAudioOutput? audioOutput,
            double? discount,
            global::OpenRouter.PublicEndpointPricingImage? image,
            global::OpenRouter.PublicEndpointPricingImageOutput? imageOutput,
            global::OpenRouter.PublicEndpointPricingImageToken? imageToken,
            global::OpenRouter.PublicEndpointPricingInputAudioCache? inputAudioCache,
            global::OpenRouter.PublicEndpointPricingInputCacheRead? inputCacheRead,
            global::OpenRouter.PublicEndpointPricingInputCacheWrite? inputCacheWrite,
            global::OpenRouter.PublicEndpointPricingInternalReasoning? internalReasoning,
            global::OpenRouter.PublicEndpointPricingRequest? request,
            global::OpenRouter.PublicEndpointPricingWebSearch? webSearch)
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
        /// Initializes a new instance of the <see cref="PublicEndpointPricing" /> class.
        /// </summary>
        public PublicEndpointPricing()
        {
        }
    }
}