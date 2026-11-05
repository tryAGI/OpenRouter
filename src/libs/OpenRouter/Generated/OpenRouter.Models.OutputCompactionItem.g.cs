
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A compaction output item carrying the encrypted summary of the compacted conversation. Emitted in reply to a `compaction_trigger` input item.<br/>
    /// Example: {"encrypted_content":"enc_abc123...","id":"cmp_abc123","type":"compaction"}
    /// </summary>
    public sealed partial class OutputCompactionItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedContent { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputCompactionItemTypeJsonConverter))]
        public global::OpenRouter.OutputCompactionItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCompactionItem" /> class.
        /// </summary>
        /// <param name="encryptedContent"></param>
        /// <param name="id"></param>
        /// <param name="createdBy"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputCompactionItem(
            string encryptedContent,
            string id,
            string? createdBy,
            global::OpenRouter.OutputCompactionItemType type)
        {
            this.CreatedBy = createdBy;
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCompactionItem" /> class.
        /// </summary>
        public OutputCompactionItem()
        {
        }

    }
}