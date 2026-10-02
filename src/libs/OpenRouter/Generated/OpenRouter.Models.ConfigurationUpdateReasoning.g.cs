
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning settings applied from this point in the conversation onward<br/>
    /// Example: {"effort":"low"}
    /// </summary>
    public sealed partial class ConfigurationUpdateReasoning
    {
        /// <summary>
        /// Reasoning effort to apply from this point in the conversation onward<br/>
        /// Example: low
        /// </summary>
        /// <example>low</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ConfigurationUpdateReasoningEffortJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ConfigurationUpdateReasoningEffort Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Reasoning effort to apply from this point in the conversation onward<br/>
        /// Example: low
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationUpdateReasoning(
            global::OpenRouter.ConfigurationUpdateReasoningEffort effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateReasoning" /> class.
        /// </summary>
        public ConfigurationUpdateReasoning()
        {
        }

    }
}