
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsScoreAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legend")]
        public object? Legend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        public global::System.Collections.Generic.Dictionary<string, double>? Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsScoreAnswerTypeJsonConverter))]
        public global::OpenRouter.DecisionsScoreAnswerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsScoreAnswer" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="confidence"></param>
        /// <param name="legend"></param>
        /// <param name="probabilities"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsScoreAnswer(
            double score,
            double? confidence,
            object? legend,
            global::System.Collections.Generic.Dictionary<string, double>? probabilities,
            global::OpenRouter.DecisionsScoreAnswerType type)
        {
            this.Confidence = confidence;
            this.Legend = legend;
            this.Probabilities = probabilities;
            this.Score = score;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsScoreAnswer" /> class.
        /// </summary>
        public DecisionsScoreAnswer()
        {
        }

    }
}