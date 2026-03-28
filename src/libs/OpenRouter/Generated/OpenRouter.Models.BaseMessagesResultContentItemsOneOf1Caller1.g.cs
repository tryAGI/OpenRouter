
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf1Caller1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf1TypeJsonConverter))]
        public global::OpenRouter.BaseMessagesResultContentItemsOneOf1CallerOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf1Caller1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="toolId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf1Caller1(
            string toolId,
            global::OpenRouter.BaseMessagesResultContentItemsOneOf1CallerOneOf1Type type)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf1Caller1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf1Caller1()
        {
        }
    }
}