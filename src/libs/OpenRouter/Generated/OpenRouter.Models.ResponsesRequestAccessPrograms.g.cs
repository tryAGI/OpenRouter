
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenAI access programs for this request. `cyber` selects the Cyber access program: `standard`, `daybreak_blue`, or `daybreak_red`. A program other than `standard` is supported only on BYOK requests that run on your own OpenAI key enrolled in that program; any other endpoint, including OpenRouter's own OpenAI credentials, rejects it with a 400 error. Requests on OpenRouter's OpenAI credentials always run `standard`. Omit the field unless your key is enrolled in a Daybreak program.<br/>
    /// Example: {"cyber":"standard"}
    /// </summary>
    public sealed partial class ResponsesRequestAccessPrograms
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponsesRequestAccessProgramsCyberJsonConverter))]
        public global::OpenRouter.ResponsesRequestAccessProgramsCyber? Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestAccessPrograms" /> class.
        /// </summary>
        /// <param name="cyber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestAccessPrograms(
            global::OpenRouter.ResponsesRequestAccessProgramsCyber? cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestAccessPrograms" /> class.
        /// </summary>
        public ResponsesRequestAccessPrograms()
        {
        }

    }
}