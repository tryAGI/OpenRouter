
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning detail summary schema
    /// </summary>
    public sealed partial class ReasoningDetailUnionVariant2
    {
        /// <summary>
        /// Discriminator value: reasoning.summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant2TypeJsonConverter))]
        public global::OpenRouter.ReasoningDetailUnionVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter))]
        public global::OpenRouter.ReasoningFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailUnionVariant2" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="type">
        /// Discriminator value: reasoning.summary
        /// </param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningDetailUnionVariant2(
            string summary,
            global::OpenRouter.ReasoningDetailUnionVariant2Type type,
            global::OpenRouter.ReasoningFormat? format,
            string? id,
            int? index)
        {
            this.Type = type;
            this.Format = format;
            this.Id = id;
            this.Index = index;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailUnionVariant2" /> class.
        /// </summary>
        public ReasoningDetailUnionVariant2()
        {
        }

    }
}