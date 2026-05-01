
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:browser_use server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant9
    {
        /// <summary>
        /// Discriminator value: openrouter:browser_use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant9TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshotB64")]
        public string? ScreenshotB64 { get; set; }

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
        /// Initializes a new instance of the <see cref="OutputItemsVariant9" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:browser_use
        /// </param>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="screenshotB64"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant9(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant9Type type,
            string? action,
            string? id,
            string? screenshotB64)
        {
            this.Type = type;
            this.Action = action;
            this.Id = id;
            this.ScreenshotB64 = screenshotB64;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant9" /> class.
        /// </summary>
        public OutputItemsVariant9()
        {
        }
    }
}