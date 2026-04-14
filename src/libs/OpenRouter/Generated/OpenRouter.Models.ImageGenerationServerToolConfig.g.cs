
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:image_generation server tool. Accepts all image_config params (aspect_ratio, quality, size, background, output_format, output_compression, moderation, etc.) plus a model field.
    /// </summary>
    public sealed partial class ImageGenerationServerToolConfig
    {
        /// <summary>
        /// Which image generation model to use (e.g. "openai/gpt-image-1"). Defaults to "openai/gpt-image-1".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerToolConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Which image generation model to use (e.g. "openai/gpt-image-1"). Defaults to "openai/gpt-image-1".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationServerToolConfig(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationServerToolConfig" /> class.
        /// </summary>
        public ImageGenerationServerToolConfig()
        {
        }
    }
}