
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:apply_patch server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant7
    {
        /// <summary>
        /// Discriminator value: openrouter:apply_patch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant7TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant7Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filePath")]
        public string? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public string? Patch { get; set; }

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
        /// Initializes a new instance of the <see cref="OutputItemsVariant7" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:apply_patch
        /// </param>
        /// <param name="filePath"></param>
        /// <param name="id"></param>
        /// <param name="patch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant7(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant7Type type,
            string? filePath,
            string? id,
            string? patch)
        {
            this.Type = type;
            this.FilePath = filePath;
            this.Id = id;
            this.Patch = patch;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant7" /> class.
        /// </summary>
        public OutputItemsVariant7()
        {
        }
    }
}