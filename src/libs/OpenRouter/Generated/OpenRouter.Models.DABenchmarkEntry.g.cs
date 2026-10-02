
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single Design Arena benchmark entry for a specific arena+category<br/>
    /// Example: {"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}
    /// </summary>
    public sealed partial class DABenchmarkEntry
    {
        /// <summary>
        /// Arena type (e.g. models, builders, agents)<br/>
        /// Example: models
        /// </summary>
        /// <example>models</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arena")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arena { get; set; }

        /// <summary>
        /// Category within the arena (e.g. website, gamedev, uicomponent)<br/>
        /// Example: website
        /// </summary>
        /// <example>website</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// ELO rating from head-to-head arena battles<br/>
        /// Example: 1385.2F
        /// </summary>
        /// <example>1385.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("elo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Elo { get; set; }

        /// <summary>
        /// Rank position within this arena+category among models available on OpenRouter (1 = highest ELO)<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// Win rate percentage in arena battles<br/>
        /// Example: 62.5F
        /// </summary>
        /// <example>62.5F</example>
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
        /// Arena type (e.g. models, builders, agents)<br/>
        /// Example: models
        /// </param>
        /// <param name="category">
        /// Category within the arena (e.g. website, gamedev, uicomponent)<br/>
        /// Example: website
        /// </param>
        /// <param name="elo">
        /// ELO rating from head-to-head arena battles<br/>
        /// Example: 1385.2F
        /// </param>
        /// <param name="rank">
        /// Rank position within this arena+category among models available on OpenRouter (1 = highest ELO)<br/>
        /// Example: 5
        /// </param>
        /// <param name="winRate">
        /// Win rate percentage in arena battles<br/>
        /// Example: 62.5F
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