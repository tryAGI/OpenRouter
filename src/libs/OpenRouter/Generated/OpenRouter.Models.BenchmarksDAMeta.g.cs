
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BenchmarksDAMeta
    {
        /// <summary>
        /// The arena filter applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arena")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arena { get; set; }

        /// <summary>
        /// ISO-8601 timestamp of when this data was generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AsOf { get; set; }

        /// <summary>
        /// The category filter applied, or null if showing all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Required attribution when republishing this data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Citation { get; set; }

        /// <summary>
        /// ELO range across all returned models for normalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elo_bounds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BenchmarksDaMetaEloBounds EloBounds { get; set; }

        /// <summary>
        /// Number of unique models in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelCount { get; set; }

        /// <summary>
        /// Data source identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BenchmarksDaMetaSourceJsonConverter))]
        public global::OpenRouter.BenchmarksDaMetaSource Source { get; set; }

        /// <summary>
        /// URL of the upstream data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BenchmarksDaMetaSourceUrlJsonConverter))]
        public global::OpenRouter.BenchmarksDaMetaSourceUrl SourceUrl { get; set; }

        /// <summary>
        /// Dataset version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BenchmarksDaMetaVersionJsonConverter))]
        public global::OpenRouter.BenchmarksDaMetaVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksDAMeta" /> class.
        /// </summary>
        /// <param name="arena">
        /// The arena filter applied.
        /// </param>
        /// <param name="asOf">
        /// ISO-8601 timestamp of when this data was generated.
        /// </param>
        /// <param name="citation">
        /// Required attribution when republishing this data.
        /// </param>
        /// <param name="eloBounds">
        /// ELO range across all returned models for normalization.
        /// </param>
        /// <param name="modelCount">
        /// Number of unique models in the response.
        /// </param>
        /// <param name="category">
        /// The category filter applied, or null if showing all.
        /// </param>
        /// <param name="source">
        /// Data source identifier.
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the upstream data source.
        /// </param>
        /// <param name="version">
        /// Dataset version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BenchmarksDAMeta(
            string arena,
            string asOf,
            string citation,
            global::OpenRouter.BenchmarksDaMetaEloBounds eloBounds,
            int modelCount,
            string? category,
            global::OpenRouter.BenchmarksDaMetaSource source,
            global::OpenRouter.BenchmarksDaMetaSourceUrl sourceUrl,
            global::OpenRouter.BenchmarksDaMetaVersion version)
        {
            this.Arena = arena ?? throw new global::System.ArgumentNullException(nameof(arena));
            this.AsOf = asOf ?? throw new global::System.ArgumentNullException(nameof(asOf));
            this.Category = category;
            this.Citation = citation ?? throw new global::System.ArgumentNullException(nameof(citation));
            this.EloBounds = eloBounds ?? throw new global::System.ArgumentNullException(nameof(eloBounds));
            this.ModelCount = modelCount;
            this.Source = source;
            this.SourceUrl = sourceUrl;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksDAMeta" /> class.
        /// </summary>
        public BenchmarksDAMeta()
        {
        }

    }
}