
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// design-arena variant
    /// </summary>
    public sealed partial class UnifiedBenchmarksResponseDataItemsVariant2
    {
        /// <summary>
        /// Discriminator value: design-arena
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsVariant2SourceJsonConverter))]
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source Source { get; set; }

        /// <summary>
        /// Arena this ranking belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arena")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arena { get; set; }

        /// <summary>
        /// Average generation time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_generation_time_ms")]
        public double? AvgGenerationTimeMs { get; set; }

        /// <summary>
        /// Category within the arena.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Human-readable model name from Design Arena.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// ELO rating from head-to-head arena battles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Elo { get; set; }

        /// <summary>
        /// Stable OpenRouter model identifier when mapped; otherwise the upstream Design Arena model id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarkPricing Pricing { get; set; }

        /// <summary>
        /// Placement distribution from tournament matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tournament_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorMappingDesignArenaTournamentStats TournamentStats { get; set; }

        /// <summary>
        /// Win rate as a percentage (0–100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("win_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WinRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksResponseDataItemsVariant2" /> class.
        /// </summary>
        /// <param name="arena">
        /// Arena this ranking belongs to.
        /// </param>
        /// <param name="category">
        /// Category within the arena.
        /// </param>
        /// <param name="displayName">
        /// Human-readable model name from Design Arena.
        /// </param>
        /// <param name="elo">
        /// ELO rating from head-to-head arena battles.
        /// </param>
        /// <param name="modelPermaslug">
        /// Stable OpenRouter model identifier when mapped; otherwise the upstream Design Arena model id.
        /// </param>
        /// <param name="pricing">
        /// OpenRouter pricing per token for this model. Null if pricing is unavailable.
        /// </param>
        /// <param name="tournamentStats">
        /// Placement distribution from tournament matches.
        /// </param>
        /// <param name="winRate">
        /// Win rate as a percentage (0–100).
        /// </param>
        /// <param name="source">
        /// Discriminator value: design-arena
        /// </param>
        /// <param name="avgGenerationTimeMs">
        /// Average generation time in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksResponseDataItemsVariant2(
            string arena,
            string category,
            string displayName,
            double elo,
            string modelPermaslug,
            global::OpenRouter.UnifiedBenchmarkPricing pricing,
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorMappingDesignArenaTournamentStats tournamentStats,
            double winRate,
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source source,
            double? avgGenerationTimeMs)
        {
            this.Source = source;
            this.Arena = arena ?? throw new global::System.ArgumentNullException(nameof(arena));
            this.AvgGenerationTimeMs = avgGenerationTimeMs;
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Elo = elo;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.TournamentStats = tournamentStats ?? throw new global::System.ArgumentNullException(nameof(tournamentStats));
            this.WinRate = winRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksResponseDataItemsVariant2" /> class.
        /// </summary>
        public UnifiedBenchmarksResponseDataItemsVariant2()
        {
        }

    }
}