
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsNoulAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noul")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Noul { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsNoulAnswerTypeJsonConverter))]
        public global::OpenRouter.DecisionsNoulAnswerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsNoulAnswer" /> class.
        /// </summary>
        /// <param name="noul"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsNoulAnswer(
            double noul,
            global::OpenRouter.DecisionsNoulAnswerType type)
        {
            this.Noul = noul;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsNoulAnswer" /> class.
        /// </summary>
        public DecisionsNoulAnswer()
        {
        }

    }
}