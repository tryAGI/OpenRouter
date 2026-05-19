
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop after the agent loop has executed this many steps.
    /// </summary>
    public sealed partial class StopServerToolsWhenConditionVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenStepCountIsTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenStepCountIsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StepCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenConditionVariant5" /> class.
        /// </summary>
        /// <param name="stepCount"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenConditionVariant5(
            int stepCount,
            global::OpenRouter.StopServerToolsWhenStepCountIsType type)
        {
            this.Type = type;
            this.StepCount = stepCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenConditionVariant5" /> class.
        /// </summary>
        public StopServerToolsWhenConditionVariant5()
        {
        }

    }
}