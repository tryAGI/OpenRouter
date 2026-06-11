
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Third-party benchmark rankings for this model. Omitted when no benchmark data is available.
    /// </summary>
    public sealed partial class ModelBenchmarks
    {
        /// <summary>
        /// Design Arena ELO rankings across arena+category pairs. The parent benchmarks object is omitted when the model has not been evaluated.
        /// </summary>
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
        /// Design Arena ELO rankings across arena+category pairs. The parent benchmarks object is omitted when the model has not been evaluated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelBenchmarks(
            global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry> designArena)
        {
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