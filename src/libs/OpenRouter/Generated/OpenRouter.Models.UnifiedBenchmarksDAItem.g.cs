
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"arena":"models","avg_generation_time_ms":3200,"category":"codecategories","display_name":"Claude Sonnet 4","elo":1423,"model_permaslug":"anthropic/claude-sonnet-4","pricing":{"completion":"0.000015","prompt":"0.000003"},"source":"design-arena","tournament_stats":{"first_place":12,"fourth_place":2,"second_place":8,"third_place":5,"total":27},"win_rate":72}
    /// </summary>
    public sealed partial class UnifiedBenchmarksDAItem
    {
        /// <summary>
        /// Arena this ranking belongs to.<br/>
        /// Example: models
        /// </summary>
        /// <example>models</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arena")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arena { get; set; }

        /// <summary>
        /// Average generation time in milliseconds.<br/>
        /// Example: 3200
        /// </summary>
        /// <example>3200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_generation_time_ms")]
        public double? AvgGenerationTimeMs { get; set; }

        /// <summary>
        /// Category within the arena.<br/>
        /// Example: codecategories
        /// </summary>
        /// <example>codecategories</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Human-readable model name from Design Arena.<br/>
        /// Example: Claude Sonnet 4
        /// </summary>
        /// <example>Claude Sonnet 4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// ELO rating from head-to-head arena battles.<br/>
        /// Example: 1423
        /// </summary>
        /// <example>1423</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("elo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Elo { get; set; }

        /// <summary>
        /// Stable OpenRouter model identifier when mapped; otherwise the upstream Design Arena model id.<br/>
        /// Example: anthropic/claude-sonnet-4
        /// </summary>
        /// <example>anthropic/claude-sonnet-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.<br/>
        /// Example: {"completion":"0.000015","prompt":"0.000003"}
        /// </summary>
        /// <example>{"completion":"0.000015","prompt":"0.000003"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::OpenRouter.UnifiedBenchmarkPricing? Pricing { get; set; }

        /// <summary>
        /// Benchmark source discriminator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksDAItemSourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksDAItemSource Source { get; set; }

        /// <summary>
        /// Placement distribution from tournament matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tournament_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksDAItemTournamentStats TournamentStats { get; set; }

        /// <summary>
        /// Win rate as a percentage (0–100).<br/>
        /// Example: 72
        /// </summary>
        /// <example>72</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("win_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WinRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksDAItem" /> class.
        /// </summary>
        /// <param name="arena">
        /// Arena this ranking belongs to.<br/>
        /// Example: models
        /// </param>
        /// <param name="category">
        /// Category within the arena.<br/>
        /// Example: codecategories
        /// </param>
        /// <param name="displayName">
        /// Human-readable model name from Design Arena.<br/>
        /// Example: Claude Sonnet 4
        /// </param>
        /// <param name="elo">
        /// ELO rating from head-to-head arena battles.<br/>
        /// Example: 1423
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier when mapped; otherwise the upstream Design Arena model id.<br/>
        /// Example: anthropic/claude-sonnet-4
        /// </param>
        /// <param name="tournamentStats">
        /// Placement distribution from tournament matches.
        /// </param>
        /// <param name="winRate">
        /// Win rate as a percentage (0–100).<br/>
        /// Example: 72
        /// </param>
        /// <param name="avgGenerationTimeMs">
        /// Average generation time in milliseconds.<br/>
        /// Example: 3200
        /// </param>
        /// <param name="pricing">
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.<br/>
        /// Example: {"completion":"0.000015","prompt":"0.000003"}
        /// </param>
        /// <param name="source">
        /// Benchmark source discriminator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksDAItem(
            string arena,
            string category,
            string displayName,
            double elo,
            string modelPermaslug,
            global::OpenRouter.UnifiedBenchmarksDAItemTournamentStats tournamentStats,
            double winRate,
            double? avgGenerationTimeMs,
            global::OpenRouter.UnifiedBenchmarkPricing? pricing,
            global::OpenRouter.UnifiedBenchmarksDAItemSource source)
        {
            this.Arena = arena ?? throw new global::System.ArgumentNullException(nameof(arena));
            this.AvgGenerationTimeMs = avgGenerationTimeMs;
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Elo = elo;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing;
            this.Source = source;
            this.TournamentStats = tournamentStats ?? throw new global::System.ArgumentNullException(nameof(tournamentStats));
            this.WinRate = winRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksDAItem" /> class.
        /// </summary>
        public UnifiedBenchmarksDAItem()
        {
        }

    }
}