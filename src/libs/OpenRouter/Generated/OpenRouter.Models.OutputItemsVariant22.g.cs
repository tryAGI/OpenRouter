
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// web_search_call variant
    /// </summary>
    public sealed partial class OutputItemsVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallTypeJsonConverter))]
        public global::OpenRouter.OutputItemWebSearchCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputItemWebSearchCallAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.WebSearchStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant22" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant22(
            global::OpenRouter.OutputItemWebSearchCallAction action,
            string id,
            global::OpenRouter.WebSearchStatus status,
            global::OpenRouter.OutputItemWebSearchCallType type)
        {
            this.Type = type;
            this.Action = action;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant22" /> class.
        /// </summary>
        public OutputItemsVariant22()
        {
        }
    }
}