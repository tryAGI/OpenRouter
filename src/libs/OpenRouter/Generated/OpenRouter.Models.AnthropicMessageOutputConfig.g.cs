
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"effort":"low"}
    /// </summary>
    public sealed partial class AnthropicMessageOutputConfig
    {
        /// <summary>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicOutputEffortJsonConverter))]
        public global::OpenRouter.AnthropicOutputEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageOutputConfig" /> class.
        /// </summary>
        /// <param name="effort">
        /// Example: high
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessageOutputConfig(
            global::OpenRouter.AnthropicOutputEffort? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageOutputConfig" /> class.
        /// </summary>
        public AnthropicMessageOutputConfig()
        {
        }

    }
}