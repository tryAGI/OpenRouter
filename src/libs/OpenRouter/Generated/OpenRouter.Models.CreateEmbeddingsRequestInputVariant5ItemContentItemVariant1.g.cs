
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1TypeJsonConverter))]
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1(
            string text,
            global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1Type type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1" /> class.
        /// </summary>
        public CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1()
        {
        }

    }
}