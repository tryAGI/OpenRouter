
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OutputToolSearchServerToolItemMatche
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Definition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaDigest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchServerToolItemMatche" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="schemaDigest"></param>
        /// <param name="toolId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputToolSearchServerToolItemMatche(
            object definition,
            string schemaDigest,
            string toolId)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.SchemaDigest = schemaDigest ?? throw new global::System.ArgumentNullException(nameof(schemaDigest));
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchServerToolItemMatche" /> class.
        /// </summary>
        public OutputToolSearchServerToolItemMatche()
        {
        }

    }
}