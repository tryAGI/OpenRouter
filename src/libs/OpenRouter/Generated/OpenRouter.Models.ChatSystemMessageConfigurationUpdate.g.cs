
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter extension. Changes reasoning effort from this point in the conversation onward without invalidating the prompt cache for the preceding turns. Place it on a content-less system message (`content: ""`) directly before the user message it should apply to, and keep it at that position in later requests. Equivalent to the OpenAI Responses `configuration_update` input item and the Anthropic Messages per-message `output_config.effort`.<br/>
    /// Example: {"reasoning":{"effort":"low"}}
    /// </summary>
    public sealed partial class ChatSystemMessageConfigurationUpdate
    {
        /// <summary>
        /// Reasoning settings applied from this point in the conversation onward<br/>
        /// Example: {"effort":"low"}
        /// </summary>
        /// <example>{"effort":"low"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ConfigurationUpdateReasoning Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessageConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Reasoning settings applied from this point in the conversation onward<br/>
        /// Example: {"effort":"low"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSystemMessageConfigurationUpdate(
            global::OpenRouter.ConfigurationUpdateReasoning reasoning)
        {
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessageConfigurationUpdate" /> class.
        /// </summary>
        public ChatSystemMessageConfigurationUpdate()
        {
        }

    }
}