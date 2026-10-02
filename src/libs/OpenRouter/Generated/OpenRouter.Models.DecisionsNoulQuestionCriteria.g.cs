
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsNoulQuestionCriteria
    {
        /// <summary>
        /// A plain string, or a JSON object or array of structured guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> False { get; set; }

        /// <summary>
        /// A plain string, or a JSON object or array of structured guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> True { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsNoulQuestionCriteria" /> class.
        /// </summary>
        /// <param name="false">
        /// A plain string, or a JSON object or array of structured guidance.
        /// </param>
        /// <param name="true">
        /// A plain string, or a JSON object or array of structured guidance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsNoulQuestionCriteria(
            global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> @false,
            global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> @true)
        {
            this.False = @false;
            this.True = @true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsNoulQuestionCriteria" /> class.
        /// </summary>
        public DecisionsNoulQuestionCriteria()
        {
        }

    }
}