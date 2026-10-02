
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// List of image generation models.<br/>
    /// Example: {"data":[{"architecture":{"input_modalities":["text"],"output_modalities":["image"]},"created":1692901234,"description":"A text-to-image model.","endpoints":"/api/v1/images/models/bytedance-seed/seedream-4.5/endpoints","id":"bytedance-seed/seedream-4.5","name":"Seedream 4.5","supported_parameters":{"resolution":{"type":"enum","values":["1K","2K","4K"]}},"supports_streaming":false}]}
    /// </summary>
    public sealed partial class ImageModelsListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelsListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageModelsListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelsListResponse" /> class.
        /// </summary>
        public ImageModelsListResponse()
        {
        }

    }
}