
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A generic OpenRouter server tool output item
    /// </summary>
    public sealed partial class OutputServerToolItem
    {
        /// <summary>
        /// Server tool type (e.g. openrouter:datetime, openrouter:web_search)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="OutputServerToolItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Server tool type (e.g. openrouter:datetime, openrouter:web_search)
        /// </param>
        /// <param name="status"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputServerToolItem(
            string type,
            global::OpenRouter.ToolCallStatus status,
            string? id)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputServerToolItem" /> class.
        /// </summary>
        public OutputServerToolItem()
        {
        }
    }
}