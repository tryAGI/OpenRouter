
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:file_search server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant14
    {
        /// <summary>
        /// Discriminator value: openrouter:file_search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant14TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant14Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant14" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:file_search
        /// </param>
        /// <param name="id"></param>
        /// <param name="queries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant14(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant14Type type,
            string? id,
            global::System.Collections.Generic.IList<string>? queries)
        {
            this.Type = type;
            this.Id = id;
            this.Queries = queries;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant14" /> class.
        /// </summary>
        public OutputItemsVariant14()
        {
        }

    }
}