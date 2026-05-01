
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning detail text schema
    /// </summary>
    public sealed partial class ReasoningDetailUnionVariant3
    {
        /// <summary>
        /// Discriminator value: reasoning.text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant3TypeJsonConverter))]
        public global::OpenRouter.ReasoningDetailUnionVariant3Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailUnionVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: reasoning.text
        /// </param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="signature"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningDetailUnionVariant3(
            global::OpenRouter.ReasoningDetailUnionVariant3Type type,
            global::OpenRouter.ReasoningFormat? format,
            string? id,
            int? index,
            string? signature,
            string? text)
        {
            this.Type = type;
            this.Format = format;
            this.Id = id;
            this.Index = index;
            this.Signature = signature;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailUnionVariant3" /> class.
        /// </summary>
        public ReasoningDetailUnionVariant3()
        {
        }
    }
}