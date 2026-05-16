
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:fusion server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant16
    {
        /// <summary>
        /// Discriminator value: openrouter:fusion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant16TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant16Type Type { get; set; }

        /// <summary>
        /// Structured analysis produced by the fusion judge model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionAnalysis? Analysis { get; set; }

        /// <summary>
        /// Error message when the fusion run did not produce an analysis result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Models that were requested as part of the analysis panel but did not produce a response. Present when at least one requested analysis model failed. The fusion result is still usable but was produced from a degraded panel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_models")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems>? FailedModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Slugs of the analysis models that produced a response in this fusion run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responses")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionResponsesItems>? Responses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant16" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:fusion
        /// </param>
        /// <param name="analysis">
        /// Structured analysis produced by the fusion judge model.
        /// </param>
        /// <param name="error">
        /// Error message when the fusion run did not produce an analysis result.
        /// </param>
        /// <param name="failedModels">
        /// Models that were requested as part of the analysis panel but did not produce a response. Present when at least one requested analysis model failed. The fusion result is still usable but was produced from a degraded panel.
        /// </param>
        /// <param name="id"></param>
        /// <param name="responses">
        /// Slugs of the analysis models that produced a response in this fusion run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant16(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant16Type type,
            global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionAnalysis? analysis,
            string? error,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems>? failedModels,
            string? id,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionResponsesItems>? responses)
        {
            this.Type = type;
            this.Analysis = analysis;
            this.Error = error;
            this.FailedModels = failedModels;
            this.Id = id;
            this.Responses = responses;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant16" /> class.
        /// </summary>
        public OutputItemsVariant16()
        {
        }

    }
}