
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailModerationPolicyConfigPiiFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigPiiFilterActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModerationPolicyConfigPiiFilterAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfigPiiFilter" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="entityType"></param>
        /// <param name="scoreThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailModerationPolicyConfigPiiFilter(
            global::OpenRouter.GuardrailModerationPolicyConfigPiiFilterAction action,
            string entityType,
            double? scoreThreshold)
        {
            this.Action = action;
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfigPiiFilter" /> class.
        /// </summary>
        public GuardrailModerationPolicyConfigPiiFilter()
        {
        }

    }
}