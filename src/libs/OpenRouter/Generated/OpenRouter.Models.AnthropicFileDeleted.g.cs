
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Deletion result in Anthropic's shape.<br/>
    /// Example: {"_shape":"anthropic","id":"or_file_011CNha8iCJcU1wXNR6q4V8w","type":"file_deleted"}
    /// </summary>
    public sealed partial class AnthropicFileDeleted
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicFileDeletedShapeJsonConverter))]
        public global::OpenRouter.AnthropicFileDeletedShape Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicFileDeletedTypeJsonConverter))]
        public global::OpenRouter.AnthropicFileDeletedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicFileDeleted" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="shape"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicFileDeleted(
            string id,
            global::OpenRouter.AnthropicFileDeletedShape shape,
            global::OpenRouter.AnthropicFileDeletedType type)
        {
            this.Shape = shape;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicFileDeleted" /> class.
        /// </summary>
        public AnthropicFileDeleted()
        {
        }

    }
}