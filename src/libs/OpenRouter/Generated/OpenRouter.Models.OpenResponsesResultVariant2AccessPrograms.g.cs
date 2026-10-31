
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Access program the upstream provider reported for this response (OpenAI `access_programs`). `null` when the provider reported none, including OpenAI's implicit Standard program.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
    /// Example: {"cyber":"standard"}
    /// </summary>
    public sealed partial class OpenResponsesResultVariant2AccessPrograms
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenResponsesResultVariant2AccessProgramsCyberJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenResponsesResultVariant2AccessProgramsCyber Cyber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResultVariant2AccessPrograms" /> class.
        /// </summary>
        /// <param name="cyber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesResultVariant2AccessPrograms(
            global::OpenRouter.OpenResponsesResultVariant2AccessProgramsCyber cyber)
        {
            this.Cyber = cyber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResultVariant2AccessPrograms" /> class.
        /// </summary>
        public OpenResponsesResultVariant2AccessPrograms()
        {
        }

    }
}