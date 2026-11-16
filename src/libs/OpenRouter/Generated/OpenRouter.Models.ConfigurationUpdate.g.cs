
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Mid-conversation configuration update. Changes reasoning effort from this point onward without invalidating the prompt cache for the preceding turns.<br/>
    /// Example: {"reasoning":{"effort":"low"}}
    /// </summary>
    public sealed partial class ConfigurationUpdate
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
        /// Initializes a new instance of the <see cref="ConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Reasoning settings applied from this point in the conversation onward<br/>
        /// Example: {"effort":"low"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationUpdate(
            global::OpenRouter.ConfigurationUpdateReasoning reasoning)
        {
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdate" /> class.
        /// </summary>
        public ConfigurationUpdate()
        {
        }

    }
}