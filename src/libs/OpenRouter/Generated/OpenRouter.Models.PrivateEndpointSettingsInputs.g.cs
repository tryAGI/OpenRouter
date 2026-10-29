
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointSettingsInputs
    {
        /// <summary>
        /// Accepts audio input. `null` keeps the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Accepts base64 file data. `null` keeps the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_files")]
        public bool? Base64Files { get; set; }

        /// <summary>
        /// Accepts base64 image data. `null` keeps the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_images")]
        public bool? Base64Images { get; set; }

        /// <summary>
        /// Accepts file URLs. `null` keeps the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_urls")]
        public bool? FileUrls { get; set; }

        /// <summary>
        /// Accepts image URLs. `null` keeps the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        public bool? ImageUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsInputs" /> class.
        /// </summary>
        /// <param name="audio">
        /// Accepts audio input. `null` keeps the provider default.
        /// </param>
        /// <param name="base64Files">
        /// Accepts base64 file data. `null` keeps the provider default.
        /// </param>
        /// <param name="base64Images">
        /// Accepts base64 image data. `null` keeps the provider default.
        /// </param>
        /// <param name="fileUrls">
        /// Accepts file URLs. `null` keeps the provider default.
        /// </param>
        /// <param name="imageUrls">
        /// Accepts image URLs. `null` keeps the provider default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointSettingsInputs(
            bool? audio,
            bool? base64Files,
            bool? base64Images,
            bool? fileUrls,
            bool? imageUrls)
        {
            this.Audio = audio;
            this.Base64Files = base64Files;
            this.Base64Images = base64Images;
            this.FileUrls = fileUrls;
            this.ImageUrls = imageUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsInputs" /> class.
        /// </summary>
        public PrivateEndpointSettingsInputs()
        {
        }

    }
}