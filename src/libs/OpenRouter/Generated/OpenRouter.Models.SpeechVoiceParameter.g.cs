
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// `enum` lists the documented voices in `values`; some providers also accept voice IDs not listed there (custom or cloned voices). `unknown` means the field is accepted but no voices are listed.<br/>
    /// Example: {"type":"enum","values":["alloy","coral"]}
    /// </summary>
    public sealed partial class SpeechVoiceParameter
    {
        /// <summary>
        /// `excluded`: `voice` is rejected when the request also sends a nonempty `input_references`. Absent: they can be combined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechVoiceParameterReferencesJsonConverter))]
        public global::OpenRouter.SpeechVoiceParameterReferences? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechVoiceParameterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechVoiceParameterType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechVoiceParameter" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="references">
        /// `excluded`: `voice` is rejected when the request also sends a nonempty `input_references`. Absent: they can be combined.
        /// </param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechVoiceParameter(
            global::OpenRouter.SpeechVoiceParameterType type,
            global::OpenRouter.SpeechVoiceParameterReferences? references,
            global::System.Collections.Generic.IList<string>? values)
        {
            this.References = references;
            this.Type = type;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechVoiceParameter" /> class.
        /// </summary>
        public SpeechVoiceParameter()
        {
        }

    }
}