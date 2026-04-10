
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// openrouter:datetime variant
    /// </summary>
    public sealed partial class OutputItemsVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputDatetimeItemTypeJsonConverter))]
        public global::OpenRouter.OutputDatetimeItemType Type { get; set; }

        /// <summary>
        /// ISO 8601 datetime string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Datetime { get; set; }

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
        /// IANA timezone name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant11" /> class.
        /// </summary>
        /// <param name="datetime">
        /// ISO 8601 datetime string
        /// </param>
        /// <param name="status"></param>
        /// <param name="timezone">
        /// IANA timezone name
        /// </param>
        /// <param name="type"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant11(
            string datetime,
            global::OpenRouter.ToolCallStatus status,
            string timezone,
            global::OpenRouter.OutputDatetimeItemType type,
            string? id)
        {
            this.Type = type;
            this.Datetime = datetime ?? throw new global::System.ArgumentNullException(nameof(datetime));
            this.Id = id;
            this.Status = status;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant11" /> class.
        /// </summary>
        public OutputItemsVariant11()
        {
        }
    }
}