
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A context compaction marker with encrypted summary
    /// </summary>
    public sealed partial class CompactionItem
    {
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
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CompactionItemTypeJsonConverter))]
        public global::OpenRouter.CompactionItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionItem" /> class.
        /// </summary>
        /// <param name="encryptedContent"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionItem(
            string encryptedContent,
            string? id,
            global::OpenRouter.CompactionItemType type)
        {
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionItem" /> class.
        /// </summary>
        public CompactionItem()
        {
        }

    }
}