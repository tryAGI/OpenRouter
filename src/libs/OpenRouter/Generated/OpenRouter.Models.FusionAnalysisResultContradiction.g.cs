
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FusionAnalysisResultContradiction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionStance> Stances { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Topic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultContradiction" /> class.
        /// </summary>
        /// <param name="stances"></param>
        /// <param name="topic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionAnalysisResultContradiction(
            global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionStance> stances,
            string topic)
        {
            this.Stances = stances ?? throw new global::System.ArgumentNullException(nameof(stances));
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultContradiction" /> class.
        /// </summary>
        public FusionAnalysisResultContradiction()
        {
        }

    }
}