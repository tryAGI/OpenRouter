
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputShellCallOutputItemOutputItemsOutcome0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExitCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputShellCallOutputItemOutputItemsOutcomeOneOf0TypeJsonConverter))]
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellCallOutputItemOutputItemsOutcome0" /> class.
        /// </summary>
        /// <param name="exitCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputShellCallOutputItemOutputItemsOutcome0(
            int exitCode,
            global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type type)
        {
            this.ExitCode = exitCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellCallOutputItemOutputItemsOutcome0" /> class.
        /// </summary>
        public OutputShellCallOutputItemOutputItemsOutcome0()
        {
        }

    }
}