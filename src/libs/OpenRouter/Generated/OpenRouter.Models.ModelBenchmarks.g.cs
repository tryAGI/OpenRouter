
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Third-party benchmark rankings for this model. Omitted when no benchmark data is available.<br/>
    /// Example: {"artificial_analysis":{"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4},"design_arena":[{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]}
    /// </summary>
    public sealed partial class ModelBenchmarks
    {
        /// <summary>
        /// Artificial Analysis benchmark index scores.<br/>
        /// Example: {"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4}
        /// </summary>
        /// <example>{"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artificial_analysis")]
        public global::OpenRouter.AABenchmarkEntry? ArtificialAnalysis { get; set; }

        /// <summary>
        /// Design Arena ELO rankings across arena+category pairs.<br/>
        /// Example: [{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]
        /// </summary>
        /// <example>[{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_arena")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry> DesignArena { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBenchmarks" /> class.
        /// </summary>
        /// <param name="designArena">
        /// Design Arena ELO rankings across arena+category pairs.<br/>
        /// Example: [{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]
        /// </param>
        /// <param name="artificialAnalysis">
        /// Artificial Analysis benchmark index scores.<br/>
        /// Example: {"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelBenchmarks(
            global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry> designArena,
            global::OpenRouter.AABenchmarkEntry? artificialAnalysis)
        {
            this.ArtificialAnalysis = artificialAnalysis;
            this.DesignArena = designArena ?? throw new global::System.ArgumentNullException(nameof(designArena));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBenchmarks" /> class.
        /// </summary>
        public ModelBenchmarks()
        {
        }

    }
}