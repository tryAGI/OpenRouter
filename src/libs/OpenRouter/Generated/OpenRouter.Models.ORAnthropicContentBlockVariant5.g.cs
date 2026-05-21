
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// container_upload variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant5
    {
        /// <summary>
        /// Discriminator value: container_upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant5TypeJsonConverter))]
        public global::OpenRouter.ORAnthropicContentBlockVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant5" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="type">
        /// Discriminator value: container_upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant5(
            string fileId,
            global::OpenRouter.ORAnthropicContentBlockVariant5Type type)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant5" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant5()
        {
        }

    }
}