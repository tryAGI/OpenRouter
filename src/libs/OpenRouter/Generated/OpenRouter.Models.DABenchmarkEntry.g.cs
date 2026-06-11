
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single Design Arena benchmark entry for a specific arena+category
    /// </summary>
    public sealed partial class DABenchmarkEntry
    {
        /// <summary>
        /// Arena type (e.g. models, builders, agents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arena")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arena { get; set; }

        /// <summary>
        /// Category within the arena (e.g. website, gamedev, uicomponent)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// ELO rating from head-to-head arena battles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Elo { get; set; }

        /// <summary>
        /// Rank position within this arena+category among models available on OpenRouter (1 = highest ELO)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// Win rate percentage in arena battles
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
        /// Initializes a new instance of the <see cref="DABenchmarkEntry" /> class.
        /// </summary>
        /// <param name="arena">
        /// Arena type (e.g. models, builders, agents)
        /// </param>
        /// <param name="category">
        /// Category within the arena (e.g. website, gamedev, uicomponent)
        /// </param>
        /// <param name="elo">
        /// ELO rating from head-to-head arena battles
        /// </param>
        /// <param name="rank">
        /// Rank position within this arena+category among models available on OpenRouter (1 = highest ELO)
        /// </param>
        /// <param name="winRate">
        /// Win rate percentage in arena battles
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DABenchmarkEntry(
            string arena,
            string category,
            double elo,
            int rank,
            double winRate)
        {
            this.Arena = arena ?? throw new global::System.ArgumentNullException(nameof(arena));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Elo = elo;
            this.Rank = rank;
            this.WinRate = winRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DABenchmarkEntry" /> class.
        /// </summary>
        public DABenchmarkEntry()
        {
        }

    }
}