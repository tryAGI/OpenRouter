
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsScoreQuestion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>> Criteria { get; set; }

        /// <summary>
        /// A plain string, or a JSON object or array of structured guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsScoreQuestionTypeJsonConverter))]
        public global::OpenRouter.DecisionsScoreQuestionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsScoreQuestion" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="instructions">
        /// A plain string, or a JSON object or array of structured guidance.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsScoreQuestion(
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>> criteria,
            global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> instructions,
            global::OpenRouter.DecisionsScoreQuestionType type)
        {
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.Instructions = instructions;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsScoreQuestion" /> class.
        /// </summary>
        public DecisionsScoreQuestion()
        {
        }

    }
}