
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Finds one target in an image in `state` and answers with one bounding box (`top`, `bottom`, `left`, `right` as fractions of the image). Served by TypeSafe Jev endpoints only; every other provider rejects a box question with `400` before anything is sent upstream.
    /// </summary>
    public sealed partial class DecisionsBoxQuestion
    {
        /// <summary>
        /// A description of the target to find, naming the image in `state` it is in; not a command, and no `criteria`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsBoxQuestionTypeJsonConverter))]
        public global::OpenRouter.DecisionsBoxQuestionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsBoxQuestion" /> class.
        /// </summary>
        /// <param name="instructions">
        /// A description of the target to find, naming the image in `state` it is in; not a command, and no `criteria`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsBoxQuestion(
            global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> instructions,
            global::OpenRouter.DecisionsBoxQuestionType type)
        {
            this.Instructions = instructions;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsBoxQuestion" /> class.
        /// </summary>
        public DecisionsBoxQuestion()
        {
        }

    }
}