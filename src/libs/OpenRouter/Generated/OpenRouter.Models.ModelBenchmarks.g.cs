
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Third-party benchmark rankings for this model. Omitted when no benchmark data is available.<br/>
    /// Example: {"artificial_analysis":{"agentic_index":55.8,"coding_index":63.2,"cyber_index":36.4,"decision_index":75.7,"economics_index":57.2,"engineering_index":60.4,"finance_and_accounting_index":58.1,"healthcare_and_medical_index":56.9,"intelligence_index":71.4,"legal_index":52.3,"multilingual_index":0.82,"openness_index":33.3,"strategy_and_ops_index":61.7},"design_arena":[{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]}
    /// </summary>
    public sealed partial class ModelBenchmarks
    {
        /// <summary>
        /// Benchmark index scores published by Artificial Analysis (artificialanalysis.ai), one field per index. Each score is the model's best on that index across the configurations Artificial Analysis evaluated (for example reasoning levels), so two indexes of one model can come from different configurations. The deprecated Coding and Agentic Index scores are the exception: both come from one configuration, the model's strongest by Intelligence Index, then Coding Index, then Agentic Index. Attribute Artificial Analysis when you republish them. Omitted when Artificial Analysis has scored the model on none of them.<br/>
        /// Example: {"agentic_index":55.8,"coding_index":63.2,"cyber_index":36.4,"decision_index":75.7,"economics_index":57.2,"engineering_index":60.4,"finance_and_accounting_index":58.1,"healthcare_and_medical_index":56.9,"intelligence_index":71.4,"legal_index":52.3,"multilingual_index":0.82,"openness_index":33.3,"strategy_and_ops_index":61.7}
        /// </summary>
        /// <example>{"agentic_index":55.8,"coding_index":63.2,"cyber_index":36.4,"decision_index":75.7,"economics_index":57.2,"engineering_index":60.4,"finance_and_accounting_index":58.1,"healthcare_and_medical_index":56.9,"intelligence_index":71.4,"legal_index":52.3,"multilingual_index":0.82,"openness_index":33.3,"strategy_and_ops_index":61.7}</example>
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
        /// Benchmark index scores published by Artificial Analysis (artificialanalysis.ai), one field per index. Each score is the model's best on that index across the configurations Artificial Analysis evaluated (for example reasoning levels), so two indexes of one model can come from different configurations. The deprecated Coding and Agentic Index scores are the exception: both come from one configuration, the model's strongest by Intelligence Index, then Coding Index, then Agentic Index. Attribute Artificial Analysis when you republish them. Omitted when Artificial Analysis has scored the model on none of them.<br/>
        /// Example: {"agentic_index":55.8,"coding_index":63.2,"cyber_index":36.4,"decision_index":75.7,"economics_index":57.2,"engineering_index":60.4,"finance_and_accounting_index":58.1,"healthcare_and_medical_index":56.9,"intelligence_index":71.4,"legal_index":52.3,"multilingual_index":0.82,"openness_index":33.3,"strategy_and_ops_index":61.7}
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