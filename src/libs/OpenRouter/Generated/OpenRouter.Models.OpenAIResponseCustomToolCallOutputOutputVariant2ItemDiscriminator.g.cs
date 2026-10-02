
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorTypeJsonConverter))]
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator(
            global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator" /> class.
        /// </summary>
        public OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator()
        {
        }

    }
}