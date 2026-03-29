
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text content part
    /// </summary>
    public sealed partial class ChatContentText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentTextTypeJsonConverter))]
        public global::OpenRouter.ChatContentTextType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Cache control for the content part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.ChatContentCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentText" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl">
        /// Cache control for the content part
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentText(
            string text,
            global::OpenRouter.ChatContentTextType type,
            global::OpenRouter.ChatContentCacheControl? cacheControl)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentText" /> class.
        /// </summary>
        public ChatContentText()
        {
        }
    }
}