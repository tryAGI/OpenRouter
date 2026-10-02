
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEmbeddingsRequestInputVariant5Item
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1, global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2, global::OpenRouter.ContentPartInputAudio, global::OpenRouter.ContentPartInputVideo, global::OpenRouter.ContentPartInputFile>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequestInputVariant5Item" /> class.
        /// </summary>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequestInputVariant5Item(
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1, global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2, global::OpenRouter.ContentPartInputAudio, global::OpenRouter.ContentPartInputVideo, global::OpenRouter.ContentPartInputFile>> content)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequestInputVariant5Item" /> class.
        /// </summary>
        public CreateEmbeddingsRequestInputVariant5Item()
        {
        }

    }
}