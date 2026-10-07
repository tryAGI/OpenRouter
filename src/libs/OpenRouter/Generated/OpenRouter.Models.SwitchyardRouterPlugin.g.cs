
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"algorithm":"stage","id":"switchyard-router"}
    /// </summary>
    public sealed partial class SwitchyardRouterPlugin
    {
        /// <summary>
        /// Routing algorithm for this request. "capability" calls a small judge model to rate how demanding the task is, then picks the efficient or capable candidate. "stage" reads the tool-result history (errors, repeated failures, edits landing) and calls the judge only when those signals are undecided. "auto" is "stage" without the judge call. "random" picks one candidate at random. "composite" keeps the tier chosen on the last human turn and re-evaluates tool turns with the stage signals. "passthrough" serves the eligible candidates in the order OpenRouter already ranked them, with no routing decision and no judge call. Omit this field to use the platform default, stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SwitchyardRouterPluginAlgorithmJsonConverter))]
        public global::OpenRouter.SwitchyardRouterPluginAlgorithm? Algorithm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SwitchyardRouterPluginIdJsonConverter))]
        public global::OpenRouter.SwitchyardRouterPluginId Id { get; set; }

        /// <summary>
        /// The model that runs the judge call for the judge-backed algorithms ("capability", "stage", and "composite"). The model must support structured outputs and have a provider that your account and request settings allow. Otherwise, the request uses the platform default judge, google/gemini-2.5-flash-lite, and reports the reason in the routing metadata. The judge call is billed to you like any other request.<br/>
        /// Example: openai/gpt-5.4-nano
        /// </summary>
        /// <example>openai/gpt-5.4-nano</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_model")]
        public string? JudgeModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchyardRouterPlugin" /> class.
        /// </summary>
        /// <param name="algorithm">
        /// Routing algorithm for this request. "capability" calls a small judge model to rate how demanding the task is, then picks the efficient or capable candidate. "stage" reads the tool-result history (errors, repeated failures, edits landing) and calls the judge only when those signals are undecided. "auto" is "stage" without the judge call. "random" picks one candidate at random. "composite" keeps the tier chosen on the last human turn and re-evaluates tool turns with the stage signals. "passthrough" serves the eligible candidates in the order OpenRouter already ranked them, with no routing decision and no judge call. Omit this field to use the platform default, stage.
        /// </param>
        /// <param name="id"></param>
        /// <param name="judgeModel">
        /// The model that runs the judge call for the judge-backed algorithms ("capability", "stage", and "composite"). The model must support structured outputs and have a provider that your account and request settings allow. Otherwise, the request uses the platform default judge, google/gemini-2.5-flash-lite, and reports the reason in the routing metadata. The judge call is billed to you like any other request.<br/>
        /// Example: openai/gpt-5.4-nano
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwitchyardRouterPlugin(
            global::OpenRouter.SwitchyardRouterPluginAlgorithm? algorithm,
            global::OpenRouter.SwitchyardRouterPluginId id,
            string? judgeModel)
        {
            this.Algorithm = algorithm;
            this.Id = id;
            this.JudgeModel = judgeModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchyardRouterPlugin" /> class.
        /// </summary>
        public SwitchyardRouterPlugin()
        {
        }

    }
}