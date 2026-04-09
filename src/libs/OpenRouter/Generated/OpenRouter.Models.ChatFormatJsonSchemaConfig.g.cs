
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// JSON Schema response format for structured outputs
    /// </summary>
    public sealed partial class ChatFormatJsonSchemaConfig
    {
        /// <summary>
        /// JSON Schema configuration object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatJsonSchemaConfig JsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatFormatJsonSchemaConfigTypeJsonConverter))]
        public global::OpenRouter.ChatFormatJsonSchemaConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatJsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// JSON Schema configuration object
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFormatJsonSchemaConfig(
            global::OpenRouter.ChatJsonSchemaConfig jsonSchema,
            global::OpenRouter.ChatFormatJsonSchemaConfigType type)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatJsonSchemaConfig" /> class.
        /// </summary>
        public ChatFormatJsonSchemaConfig()
        {
        }
    }
}