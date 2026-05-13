
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// fusion variant
    /// </summary>
    public sealed partial class MessagesRequestPluginsItemsVariant4
    {
        /// <summary>
        /// Discriminator value: fusion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant4IdJsonConverter))]
        public global::OpenRouter.MessagesRequestPluginsItemsVariant4Id Id { get; set; }

        /// <summary>
        /// Slugs of models to run in parallel as the "expert panel" the judge analyzes. Each model receives the same user prompt with web_search + web_fetch enabled. Capped at 8 models to bound cost amplification. When omitted, defaults to the Quality preset from the /labs/fusion UI (~anthropic/claude-opus-latest, ~openai/gpt-latest, ~google/gemini-pro-latest).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_models")]
        public global::System.Collections.Generic.IList<string>? AnalysisModels { get; set; }

        /// <summary>
        /// Set to false to disable the fusion plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Slug of the model that performs both the judge step (with web_search + web_fetch) and the final synthesis. When omitted, defaults to the first model in the Quality preset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant4" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: fusion
        /// </param>
        /// <param name="analysisModels">
        /// Slugs of models to run in parallel as the "expert panel" the judge analyzes. Each model receives the same user prompt with web_search + web_fetch enabled. Capped at 8 models to bound cost amplification. When omitted, defaults to the Quality preset from the /labs/fusion UI (~anthropic/claude-opus-latest, ~openai/gpt-latest, ~google/gemini-pro-latest).
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the fusion plugin for this request. Defaults to true.
        /// </param>
        /// <param name="model">
        /// Slug of the model that performs both the judge step (with web_search + web_fetch) and the final synthesis. When omitted, defaults to the first model in the Quality preset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestPluginsItemsVariant4(
            global::OpenRouter.MessagesRequestPluginsItemsVariant4Id id,
            global::System.Collections.Generic.IList<string>? analysisModels,
            bool? enabled,
            string? model)
        {
            this.Id = id;
            this.AnalysisModels = analysisModels;
            this.Enabled = enabled;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant4" /> class.
        /// </summary>
        public MessagesRequestPluginsItemsVariant4()
        {
        }

    }
}