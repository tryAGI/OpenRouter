
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicCompactionBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCompactionBlockTypeJsonConverter))]
        public global::OpenRouter.AnthropicCompactionBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCompactionBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicCompactionBlock(
            string? content,
            global::OpenRouter.AnthropicCompactionBlockType type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCompactionBlock" /> class.
        /// </summary>
        public AnthropicCompactionBlock()
        {
        }
    }
}