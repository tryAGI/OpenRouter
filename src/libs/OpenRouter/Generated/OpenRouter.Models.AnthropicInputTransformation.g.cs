
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A server-side transformation Anthropic applied to the request input<br/>
    /// Example: {"path":"messages.1.content.0","reason":"prefix_binding_mismatch","type":"thinking_dropped"}
    /// </summary>
    public sealed partial class AnthropicInputTransformation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicInputTransformation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="path"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicInputTransformation(
            string type,
            string? path,
            string? reason)
        {
            this.Path = path;
            this.Reason = reason;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicInputTransformation" /> class.
        /// </summary>
        public AnthropicInputTransformation()
        {
        }

    }
}