
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// JSON object response format<br/>
    /// Example: {"type":"json_object"}
    /// </summary>
    public sealed partial class ChatFormatJsonObjectConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatFormatJsonObjectConfigTypeJsonConverter))]
        public global::OpenRouter.ChatFormatJsonObjectConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatJsonObjectConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFormatJsonObjectConfig(
            global::OpenRouter.ChatFormatJsonObjectConfigType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatJsonObjectConfig" /> class.
        /// </summary>
        public ChatFormatJsonObjectConfig()
        {
        }

    }
}