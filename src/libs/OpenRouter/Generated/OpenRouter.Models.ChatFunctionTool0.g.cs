
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatFunctionTool0
    {
        /// <summary>
        /// Cache control for the content part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.ChatContentCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Function definition for tool calling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatFunctionToolOneOf0Function Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatFunctionToolOneOf0TypeJsonConverter))]
        public global::OpenRouter.ChatFunctionToolOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionTool0" /> class.
        /// </summary>
        /// <param name="function">
        /// Function definition for tool calling
        /// </param>
        /// <param name="cacheControl">
        /// Cache control for the content part
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFunctionTool0(
            global::OpenRouter.ChatFunctionToolOneOf0Function function,
            global::OpenRouter.ChatContentCacheControl? cacheControl,
            global::OpenRouter.ChatFunctionToolOneOf0Type type)
        {
            this.CacheControl = cacheControl;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionTool0" /> class.
        /// </summary>
        public ChatFunctionTool0()
        {
        }
    }
}