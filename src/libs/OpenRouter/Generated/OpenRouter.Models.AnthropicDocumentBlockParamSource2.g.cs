
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicDocumentBlockParamSource2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeJsonConverter))]
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParamSource2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicDocumentBlockParamSource2(
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content content,
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParamSource2" /> class.
        /// </summary>
        public AnthropicDocumentBlockParamSource2()
        {
        }
    }
}