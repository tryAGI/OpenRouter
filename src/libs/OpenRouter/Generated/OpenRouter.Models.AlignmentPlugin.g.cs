
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Beta. States the listed rules to the model and evaluates every turn against them; the configuration, metadata, and error shapes may change.<br/>
    /// Example: {"id":"alignment","mode":"audit","rules":[{"rule":"Never offer a discount.","watch":["content"]}]}
    /// </summary>
    public sealed partial class AlignmentPlugin
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentPluginIdJsonConverter))]
        public global::OpenRouter.AlignmentPluginId Id { get; set; }

        /// <summary>
        /// Whether the rules are stated to the model in a system message on every provider call. Default true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct")]
        public bool? Instruct { get; set; }

        /// <summary>
        /// Provider calls made again after a blocked turn, in enforce mode. Default 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// `enforce`: a turn that breaks a rule is withheld, retried, and finally returned as an error. `audit`: every turn is evaluated and returned. Default `audit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentPluginModeJsonConverter))]
        public global::OpenRouter.AlignmentPluginMode? Mode { get; set; }

        /// <summary>
        /// Rules the reply must follow. Each rule is evaluated on its own.<br/>
        /// Example: [{"rule":"Never offer a discount.","watch":["content"]}, {"rule":"Never call delete_file.","watch":["tool_calls"]}]
        /// </summary>
        /// <example>[{"rule":"Never offer a discount.","watch":["content"]}, {"rule":"Never call delete_file.","watch":["tool_calls"]}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRule> Rules { get; set; }

        /// <summary>
        /// Probability at or above which a rule is broken, from 0.01 to 1. Default 0.7.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentPlugin" /> class.
        /// </summary>
        /// <param name="rules">
        /// Rules the reply must follow. Each rule is evaluated on its own.<br/>
        /// Example: [{"rule":"Never offer a discount.","watch":["content"]}, {"rule":"Never call delete_file.","watch":["tool_calls"]}]
        /// </param>
        /// <param name="id"></param>
        /// <param name="instruct">
        /// Whether the rules are stated to the model in a system message on every provider call. Default true.
        /// </param>
        /// <param name="maxRetries">
        /// Provider calls made again after a blocked turn, in enforce mode. Default 1.
        /// </param>
        /// <param name="mode">
        /// `enforce`: a turn that breaks a rule is withheld, retried, and finally returned as an error. `audit`: every turn is evaluated and returned. Default `audit`.
        /// </param>
        /// <param name="threshold">
        /// Probability at or above which a rule is broken, from 0.01 to 1. Default 0.7.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentPlugin(
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRule> rules,
            global::OpenRouter.AlignmentPluginId id,
            bool? instruct,
            int? maxRetries,
            global::OpenRouter.AlignmentPluginMode? mode,
            double? threshold)
        {
            this.Id = id;
            this.Instruct = instruct;
            this.MaxRetries = maxRetries;
            this.Mode = mode;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentPlugin" /> class.
        /// </summary>
        public AlignmentPlugin()
        {
        }

    }
}