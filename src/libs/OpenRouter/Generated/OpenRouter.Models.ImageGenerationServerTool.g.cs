
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation tool configuration
    /// </summary>
    public sealed partial class ImageGenerationServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolBackgroundJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolBackground? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_fidelity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolInputFidelityJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolInputFidelity? InputFidelity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_mask")]
        public global::OpenRouter.ImageGenerationServerToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolModerationJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolModeration? Moderation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolOutputFormatJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_images")]
        public int? PartialImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolQualityJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolTypeJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerTool" /> class.
        /// </summary>
        /// <param name="background"></param>
        /// <param name="inputFidelity"></param>
        /// <param name="inputImageMask"></param>
        /// <param name="model"></param>
        /// <param name="moderation"></param>
        /// <param name="outputCompression"></param>
        /// <param name="outputFormat"></param>
        /// <param name="partialImages"></param>
        /// <param name="quality"></param>
        /// <param name="size"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationServerTool(
            global::OpenRouter.ImageGenerationServerToolBackground? background,
            global::OpenRouter.ImageGenerationServerToolInputFidelity? inputFidelity,
            global::OpenRouter.ImageGenerationServerToolInputImageMask? inputImageMask,
            string? model,
            global::OpenRouter.ImageGenerationServerToolModeration? moderation,
            int? outputCompression,
            global::OpenRouter.ImageGenerationServerToolOutputFormat? outputFormat,
            int? partialImages,
            global::OpenRouter.ImageGenerationServerToolQuality? quality,
            string? size,
            global::OpenRouter.ImageGenerationServerToolType type)
        {
            this.Background = background;
            this.InputFidelity = inputFidelity;
            this.InputImageMask = inputImageMask;
            this.Model = model;
            this.Moderation = moderation;
            this.OutputCompression = outputCompression;
            this.OutputFormat = outputFormat;
            this.PartialImages = partialImages;
            this.Quality = quality;
            this.Size = size;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerTool" /> class.
        /// </summary>
        public ImageGenerationServerTool()
        {
        }

    }
}