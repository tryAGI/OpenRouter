
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Changes reasoning effort from this point in the conversation onward without invalidating the prompt cache for the preceding items. Place it before the user message it should apply to; it stays in effect until another configuration update. Two adjacent configuration updates are rejected. Only supported by models that accept mid-conversation effort changes.<br/>
    /// Example: {"reasoning":{"effort":"low"},"type":"configuration_update"}
    /// </summary>
    public sealed partial class ConfigurationUpdateItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Reasoning settings applied from this point in the conversation onward<br/>
        /// Example: {"effort":"low"}
        /// </summary>
        /// <example>{"effort":"low"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ConfigurationUpdateReasoning Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ConfigurationUpdateItemTypeJsonConverter))]
        public global::OpenRouter.ConfigurationUpdateItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateItem" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Reasoning settings applied from this point in the conversation onward<br/>
        /// Example: {"effort":"low"}
        /// </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationUpdateItem(
            global::OpenRouter.ConfigurationUpdateReasoning reasoning,
            string? id,
            global::OpenRouter.ConfigurationUpdateItemType type)
        {
            this.Id = id;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateItem" /> class.
        /// </summary>
        public ConfigurationUpdateItem()
        {
        }

    }
}