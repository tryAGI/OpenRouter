
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A server-side safeguard Anthropic evaluates alongside the completion<br/>
    /// Example: {"classifier_context":{"permission_mode":"auto","v":1},"type":"dangerous_tool_use"}
    /// </summary>
    public sealed partial class AnthropicSafeguard
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context")]
        public object? ClassifierContext { get; set; }

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
        /// Initializes a new instance of the <see cref="AnthropicSafeguard" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="classifierContext"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicSafeguard(
            string type,
            object? classifierContext)
        {
            this.ClassifierContext = classifierContext;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicSafeguard" /> class.
        /// </summary>
        public AnthropicSafeguard()
        {
        }

    }
}