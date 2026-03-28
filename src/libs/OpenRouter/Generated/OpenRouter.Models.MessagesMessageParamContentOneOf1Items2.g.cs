
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2TypeJsonConverter))]
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Source Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Citations, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Citations, object>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="source"></param>
        /// <param name="citations"></param>
        /// <param name="context"></param>
        /// <param name="title"></param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1Items2(
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Source source,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Type type,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2Citations, object>? citations,
            string? context,
            string? title,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl? cacheControl)
        {
            this.Source = source;
            this.Type = type;
            this.Citations = citations;
            this.Context = context;
            this.Title = title;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items2" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items2()
        {
        }
    }
}