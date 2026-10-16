
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsBoxAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DecisionsBoxAnswerBox Box { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsBoxAnswerTypeJsonConverter))]
        public global::OpenRouter.DecisionsBoxAnswerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsBoxAnswer" /> class.
        /// </summary>
        /// <param name="box"></param>
        /// <param name="confidence"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsBoxAnswer(
            global::OpenRouter.DecisionsBoxAnswerBox box,
            double? confidence,
            global::OpenRouter.DecisionsBoxAnswerType type)
        {
            this.Box = box ?? throw new global::System.ArgumentNullException(nameof(box));
            this.Confidence = confidence;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsBoxAnswer" /> class.
        /// </summary>
        public DecisionsBoxAnswer()
        {
        }

    }
}