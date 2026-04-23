
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:browser_use server tool output item
    /// </summary>
    public sealed partial class OutputBrowserUseServerToolItem
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputBrowserUseServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputBrowserUseServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBrowserUseServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="screenshotB64"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputBrowserUseServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? action,
            string? id,
            string? screenshotB64,
            global::OpenRouter.OutputBrowserUseServerToolItemType type)
        {
            this.Action = action;
            this.Id = id;
            this.ScreenshotB64 = screenshotB64;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBrowserUseServerToolItem" /> class.
        /// </summary>
        public OutputBrowserUseServerToolItem()
        {
        }
    }
}