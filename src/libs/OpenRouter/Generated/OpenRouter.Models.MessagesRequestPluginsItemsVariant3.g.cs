
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// file-parser variant
    /// </summary>
    public sealed partial class MessagesRequestPluginsItemsVariant3
    {
        /// <summary>
        /// Discriminator value: file-parser
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant3IdJsonConverter))]
        public global::OpenRouter.MessagesRequestPluginsItemsVariant3Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the file-parser plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Options for PDF parsing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf")]
        public global::OpenRouter.PDFParserOptions? Pdf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant3" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: file-parser
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the file-parser plugin for this request. Defaults to true.
        /// </param>
        /// <param name="pdf">
        /// Options for PDF parsing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestPluginsItemsVariant3(
            global::OpenRouter.MessagesRequestPluginsItemsVariant3Id id,
            bool? enabled,
            global::OpenRouter.PDFParserOptions? pdf)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Pdf = pdf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant3" /> class.
        /// </summary>
        public MessagesRequestPluginsItemsVariant3()
        {
        }

    }
}