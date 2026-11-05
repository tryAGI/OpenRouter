
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The provider declined to answer this question; no value or probabilities are returned. Other questions in the same request can still have answers.
    /// </summary>
    public sealed partial class DecisionsRefusalAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsRefusalAnswerTypeJsonConverter))]
        public global::OpenRouter.DecisionsRefusalAnswerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsRefusalAnswer" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsRefusalAnswer(
            global::OpenRouter.DecisionsRefusalAnswerType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsRefusalAnswer" /> class.
        /// </summary>
        public DecisionsRefusalAnswer()
        {
        }

    }
}