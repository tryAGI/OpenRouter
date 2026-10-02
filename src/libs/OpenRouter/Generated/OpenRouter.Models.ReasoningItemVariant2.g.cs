
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReasoningItemVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// Example: unknown
        /// </summary>
        /// <example>unknown</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter))]
        public global::OpenRouter.ReasoningFormat? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemVariant2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="format">
        /// Example: unknown
        /// </param>
        /// <param name="signature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItemVariant2(
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? content,
            global::OpenRouter.ReasoningFormat? format,
            string? signature)
        {
            this.Content = content;
            this.Format = format;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemVariant2" /> class.
        /// </summary>
        public ReasoningItemVariant2()
        {
        }

    }
}