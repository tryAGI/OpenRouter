
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Third-party benchmark rankings for this model. Omitted when no benchmark data is available.
    /// </summary>
    public sealed partial class ModelBenchmarks
    {
        /// <summary>
        /// Artificial Analysis benchmark index scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artificial_analysis")]
        public global::OpenRouter.AABenchmarkEntry? ArtificialAnalysis { get; set; }

        /// <summary>
        /// Design Arena ELO rankings across arena+category pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_arena")]
        public global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>? DesignArena { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBenchmarks" /> class.
        /// </summary>
        /// <param name="artificialAnalysis">
        /// Artificial Analysis benchmark index scores.
        /// </param>
        /// <param name="designArena">
        /// Design Arena ELO rankings across arena+category pairs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelBenchmarks(
            global::OpenRouter.AABenchmarkEntry? artificialAnalysis,
            global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>? designArena)
        {
            this.ArtificialAnalysis = artificialAnalysis;
            this.DesignArena = designArena;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBenchmarks" /> class.
        /// </summary>
        public ModelBenchmarks()
        {
        }

    }
}