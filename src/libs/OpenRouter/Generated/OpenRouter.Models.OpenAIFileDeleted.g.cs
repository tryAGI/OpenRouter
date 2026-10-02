
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Deletion result in OpenAI's shape.<br/>
    /// Example: {"_shape":"openai","deleted":true,"id":"or_file_011CNha8iCJcU1wXNR6q4V8w","object":"file"}
    /// </summary>
    public sealed partial class OpenAIFileDeleted
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileDeletedShapeJsonConverter))]
        public global::OpenRouter.OpenAIFileDeletedShape Shape { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = true;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIFileDeletedObjectJsonConverter))]
        public global::OpenRouter.OpenAIFileDeletedObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFileDeleted" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="shape"></param>
        /// <param name="object"></param>
        /// <param name="deleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFileDeleted(
            string id,
            global::OpenRouter.OpenAIFileDeletedShape shape,
            global::OpenRouter.OpenAIFileDeletedObject @object,
            bool deleted = true)
        {
            this.Shape = shape;
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFileDeleted" /> class.
        /// </summary>
        public OpenAIFileDeleted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="OpenAIFileDeleted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OpenAIFileDeleted FromId(string id)
        {
            return new OpenAIFileDeleted
            {
                Id = id,
            };
        }

    }
}