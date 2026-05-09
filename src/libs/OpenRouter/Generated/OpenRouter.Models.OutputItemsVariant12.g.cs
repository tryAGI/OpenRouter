
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:datetime server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant12
    {
        /// <summary>
        /// Discriminator value: openrouter:datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant12TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant12Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="OutputItemsVariant12" /> class.
        /// </summary>
        /// <param name="datetime">
        /// ISO 8601 datetime string
        /// </param>
        /// <param name="status"></param>
        /// <param name="timezone">
        /// IANA timezone name
        /// </param>
        /// <param name="type">
        /// Discriminator value: openrouter:datetime
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant12(
            string datetime,
            global::OpenRouter.ToolCallStatus status,
            string timezone,
            global::OpenRouter.OutputItemsVariant12Type type,
            string? id)
        {
            this.Type = type;
            this.Datetime = datetime ?? throw new global::System.ArgumentNullException(nameof(datetime));
            this.Id = id;
            this.Status = status;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant12" /> class.
        /// </summary>
        public OutputItemsVariant12()
        {
        }
    }
}