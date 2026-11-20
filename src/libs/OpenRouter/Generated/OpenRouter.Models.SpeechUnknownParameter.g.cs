
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"type":"unknown"}
    /// </summary>
    public sealed partial class SpeechUnknownParameter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechUnknownParameterTypeJsonConverter))]
        public global::OpenRouter.SpeechUnknownParameterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechUnknownParameter" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechUnknownParameter(
            global::OpenRouter.SpeechUnknownParameterType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechUnknownParameter" /> class.
        /// </summary>
        public SpeechUnknownParameter()
        {
        }

    }
}