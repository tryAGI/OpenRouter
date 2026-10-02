
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"prefix_mismatch_behavior":"drop_block"}
    /// </summary>
    public sealed partial class AnthropicThinkingBlockBinding
    {
        /// <summary>
        /// Deprecated: legacy alias of prefix_mismatch_behavior. Send only one of the two.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mismatch_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicThinkingBlockBindingMismatchBehaviorJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::OpenRouter.AnthropicThinkingBlockBindingMismatchBehavior? MismatchBehavior { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_mismatch_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicThinkingBlockBindingPrefixMismatchBehaviorJsonConverter))]
        public global::OpenRouter.AnthropicThinkingBlockBindingPrefixMismatchBehavior? PrefixMismatchBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingBlockBinding" /> class.
        /// </summary>
        /// <param name="prefixMismatchBehavior"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicThinkingBlockBinding(
            global::OpenRouter.AnthropicThinkingBlockBindingPrefixMismatchBehavior? prefixMismatchBehavior)
        {
            this.PrefixMismatchBehavior = prefixMismatchBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingBlockBinding" /> class.
        /// </summary>
        public AnthropicThinkingBlockBinding()
        {
        }

    }
}