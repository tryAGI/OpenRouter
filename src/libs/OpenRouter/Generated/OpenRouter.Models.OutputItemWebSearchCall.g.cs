
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"action":{"query":"OpenAI API","type":"search"},"id":"search-abc123","status":"completed","type":"web_search_call"}
    /// </summary>
    public sealed partial class OutputItemWebSearchCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.OutputItemWebSearchCallActionVariant1, global::OpenRouter.OutputItemWebSearchCallActionVariant2, global::OpenRouter.OutputItemWebSearchCallActionVariant3>))]
        public global::OpenRouter.OneOf<global::OpenRouter.OutputItemWebSearchCallActionVariant1, global::OpenRouter.OutputItemWebSearchCallActionVariant2, global::OpenRouter.OutputItemWebSearchCallActionVariant3>? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.WebSearchStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallTypeJsonConverter))]
        public global::OpenRouter.OutputItemWebSearchCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCall" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="action"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemWebSearchCall(
            string id,
            global::OpenRouter.WebSearchStatus status,
            global::OpenRouter.OneOf<global::OpenRouter.OutputItemWebSearchCallActionVariant1, global::OpenRouter.OutputItemWebSearchCallActionVariant2, global::OpenRouter.OutputItemWebSearchCallActionVariant3>? action,
            global::OpenRouter.OutputItemWebSearchCallType type)
        {
            this.Action = action;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCall" /> class.
        /// </summary>
        public OutputItemWebSearchCall()
        {
        }

    }
}