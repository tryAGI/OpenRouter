
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolChoice0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_parallel_tool_use")]
        public bool? DisableParallelToolUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestToolChoiceOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolChoice0" /> class.
        /// </summary>
        /// <param name="disableParallelToolUse"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolChoice0(
            bool? disableParallelToolUse,
            global::OpenRouter.MessagesRequestToolChoiceOneOf0Type type)
        {
            this.DisableParallelToolUse = disableParallelToolUse;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolChoice0" /> class.
        /// </summary>
        public MessagesRequestToolChoice0()
        {
        }
    }
}