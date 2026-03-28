
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSearchServerToolRankingOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FileSearchServerToolRankingOptionsRankerJsonConverter))]
        public global::OpenRouter.FileSearchServerToolRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerToolRankingOptions" /> class.
        /// </summary>
        /// <param name="ranker"></param>
        /// <param name="scoreThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchServerToolRankingOptions(
            global::OpenRouter.FileSearchServerToolRankingOptionsRanker? ranker,
            double? scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerToolRankingOptions" /> class.
        /// </summary>
        public FileSearchServerToolRankingOptions()
        {
        }
    }
}