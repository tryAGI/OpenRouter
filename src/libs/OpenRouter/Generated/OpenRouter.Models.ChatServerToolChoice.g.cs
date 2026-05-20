
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter extension: force a specific server tool by naming it directly in `tool_choice.type` instead of wrapping it in `{ type: "function", function: { name } }`.
    /// </summary>
    public sealed partial class ChatServerToolChoice
    {
        /// <summary>
        /// OpenRouter server-tool type to force (e.g. `openrouter:web_search`, `web_search`, `web_search_preview`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatServerToolChoice" /> class.
        /// </summary>
        /// <param name="type">
        /// OpenRouter server-tool type to force (e.g. `openrouter:web_search`, `web_search`, `web_search_preview`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatServerToolChoice(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatServerToolChoice" /> class.
        /// </summary>
        public ChatServerToolChoice()
        {
        }

    }
}