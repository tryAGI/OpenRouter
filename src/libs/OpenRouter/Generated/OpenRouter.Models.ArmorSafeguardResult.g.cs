
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The outcome of OpenRouter Armor for each client tool call of the response, keyed by tool-call id, in the same shape Anthropic reports its server-side safeguards.<br/>
    /// Example: {"status":{"tool_uses":{"call_abc":{"explanation":"[Data Exfiltration]","outcome":"flagged","type":"evaluated"},"call_def":{"outcome":"not_flagged","type":"evaluated"}},"type":"available"},"type":"dangerous_tool_use"}
    /// </summary>
    public sealed partial class ArmorSafeguardResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ArmorSafeguardResultStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorSafeguardResultTypeJsonConverter))]
        public global::OpenRouter.ArmorSafeguardResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorSafeguardResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArmorSafeguardResult(
            global::OpenRouter.ArmorSafeguardResultStatus status,
            global::OpenRouter.ArmorSafeguardResultType type)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorSafeguardResult" /> class.
        /// </summary>
        public ArmorSafeguardResult()
        {
        }

    }
}