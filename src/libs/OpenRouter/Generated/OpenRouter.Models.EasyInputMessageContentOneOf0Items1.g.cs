
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image input content item
    /// </summary>
    public sealed partial class EasyInputMessageContentOneOf0Items1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputImageDetail Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputImageTypeJsonConverter))]
        public global::OpenRouter.InputImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EasyInputMessageContentOneOf0Items1" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EasyInputMessageContentOneOf0Items1(
            global::OpenRouter.InputImageDetail detail,
            string? imageUrl,
            global::OpenRouter.InputImageType type)
        {
            this.Detail = detail;
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EasyInputMessageContentOneOf0Items1" /> class.
        /// </summary>
        public EasyInputMessageContentOneOf0Items1()
        {
        }
    }
}