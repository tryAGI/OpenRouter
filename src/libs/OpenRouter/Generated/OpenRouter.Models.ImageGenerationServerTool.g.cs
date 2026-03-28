
#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolTypeJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>? InputFidelity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_mask")]
        public global::OpenRouter.ImageGenerationServerToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolModelJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolModel? Model { get; set; }

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
        public double? OutputCompression { get; set; }

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
        public double? PartialImages { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolSizeJsonConverter))]
        public global::OpenRouter.ImageGenerationServerToolSize? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationServerTool(
            global::OpenRouter.ImageGenerationServerToolType type,
            global::OpenRouter.ImageGenerationServerToolBackground? background,
            global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>? inputFidelity,
            global::OpenRouter.ImageGenerationServerToolInputImageMask? inputImageMask,
            global::OpenRouter.ImageGenerationServerToolModel? model,
            global::OpenRouter.ImageGenerationServerToolModeration? moderation,
            double? outputCompression,
            global::OpenRouter.ImageGenerationServerToolOutputFormat? outputFormat,
            double? partialImages,
            global::OpenRouter.ImageGenerationServerToolQuality? quality,
            global::OpenRouter.ImageGenerationServerToolSize? size)
        {
            this.Type = type;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerTool" /> class.
        /// </summary>
        public ImageGenerationServerTool()
        {
        }
    }
}