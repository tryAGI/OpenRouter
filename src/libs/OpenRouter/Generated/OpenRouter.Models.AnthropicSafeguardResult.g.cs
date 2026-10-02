
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The outcome of a server-side safeguard, keyed by tool-use id where applicable<br/>
    /// Example: {"status":{"tool_uses":{"toolu_01ABC":{"outcome":"not_flagged","type":"evaluated"}},"type":"available"},"type":"dangerous_tool_use"}
    /// </summary>
    public sealed partial class AnthropicSafeguardResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicSafeguardResultStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="AnthropicSafeguardResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicSafeguardResult(
            global::OpenRouter.AnthropicSafeguardResultStatus status,
            string type)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicSafeguardResult" /> class.
        /// </summary>
        public AnthropicSafeguardResult()
        {
        }

    }
}