
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsChoiceAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Choice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        public global::System.Collections.Generic.Dictionary<string, double>? Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsChoiceAnswerTypeJsonConverter))]
        public global::OpenRouter.DecisionsChoiceAnswerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsChoiceAnswer" /> class.
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="confidence"></param>
        /// <param name="probabilities"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsChoiceAnswer(
            string choice,
            double? confidence,
            global::System.Collections.Generic.Dictionary<string, double>? probabilities,
            global::OpenRouter.DecisionsChoiceAnswerType type)
        {
            this.Choice = choice ?? throw new global::System.ArgumentNullException(nameof(choice));
            this.Confidence = confidence;
            this.Probabilities = probabilities;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsChoiceAnswer" /> class.
        /// </summary>
        public DecisionsChoiceAnswer()
        {
        }

    }
}