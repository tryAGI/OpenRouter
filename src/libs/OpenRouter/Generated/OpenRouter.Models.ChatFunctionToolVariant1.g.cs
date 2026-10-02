
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatFunctionToolVariant1
    {
        /// <summary>
        /// Anthropic-style cache breakpoint for the content part. Interchangeable with the OpenAI-style `prompt_cache_breakpoint` marker: OpenRouter converts between the two based on the provider serving the request.<br/>
        /// Example: {"ttl":"5m","type":"ephemeral"}
        /// </summary>
        /// <example>{"ttl":"5m","type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentCacheControlJsonConverter))]
        public global::OpenRouter.ChatContentCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Function definition for tool calling<br/>
        /// Example: {"description":"Get the current weather for a location","name":"get_weather","parameters":{"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}}
        /// </summary>
        /// <example>{"description":"Get the current weather for a location","name":"get_weather","parameters":{"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatFunctionToolVariant1Function Function { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatFunctionToolVariant1TypeJsonConverter))]
        public global::OpenRouter.ChatFunctionToolVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionToolVariant1" /> class.
        /// </summary>
        /// <param name="function">
        /// Function definition for tool calling<br/>
        /// Example: {"description":"Get the current weather for a location","name":"get_weather","parameters":{"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}}
        /// </param>
        /// <param name="cacheControl">
        /// Anthropic-style cache breakpoint for the content part. Interchangeable with the OpenAI-style `prompt_cache_breakpoint` marker: OpenRouter converts between the two based on the provider serving the request.<br/>
        /// Example: {"ttl":"5m","type":"ephemeral"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFunctionToolVariant1(
            global::OpenRouter.ChatFunctionToolVariant1Function function,
            global::OpenRouter.ChatContentCacheControl? cacheControl,
            global::OpenRouter.ChatFunctionToolVariant1Type type)
        {
            this.CacheControl = cacheControl;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionToolVariant1" /> class.
        /// </summary>
        public ChatFunctionToolVariant1()
        {
        }

    }
}