
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Benchmark index scores published by Artificial Analysis (artificialanalysis.ai), one field per index. Each score is the model's best on that index across the configurations Artificial Analysis evaluated (for example reasoning levels), so two indexes of one model can come from different configurations. The deprecated Coding Index and Agentic Index fields are null for every model: Artificial Analysis has retired those indexes. Attribute Artificial Analysis when you republish them. Omitted when Artificial Analysis has scored the model on none of them.<br/>
    /// Example: {"agentic_index":null,"coding_index":null,"cyber_index":36.4,"decision_index":75.7,"economics_index":57.2,"engineering_index":60.4,"finance_and_accounting_index":58.1,"healthcare_and_medical_index":56.9,"intelligence_index":71.4,"legal_index":52.3,"multilingual_index":0.82,"openness_index":33.3,"strategy_and_ops_index":61.7}
    /// </summary>
    public sealed partial class AABenchmarkEntry
    {
        /// <summary>
        /// Deprecated: Artificial Analysis has retired its Agentic Index and no longer publishes it. Always null.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_index")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? AgenticIndex { get; set; }

        /// <summary>
        /// Deprecated: Artificial Analysis has retired its Coding Index and no longer publishes it. Always null.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coding_index")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? CodingIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Cyber Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 36.4F
        /// </summary>
        /// <example>36.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber_index")]
        public double? CyberIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Decision Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Published for decision models and for the language models Artificial Analysis evaluates on decision tasks. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 75.7F
        /// </summary>
        /// <example>75.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision_index")]
        public double? DecisionIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Economics Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 57.2F
        /// </summary>
        /// <example>57.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("economics_index")]
        public double? EconomicsIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Engineering Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 60.4F
        /// </summary>
        /// <example>60.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("engineering_index")]
        public double? EngineeringIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Finance &amp; Accounting Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 58.1F
        /// </summary>
        /// <example>58.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finance_and_accounting_index")]
        public double? FinanceAndAccountingIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Healthcare &amp; Medical Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 56.9F
        /// </summary>
        /// <example>56.9F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthcare_and_medical_index")]
        public double? HealthcareAndMedicalIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Intelligence Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 71.4F
        /// </summary>
        /// <example>71.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence_index")]
        public double? IntelligenceIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Legal Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 52.3F
        /// </summary>
        /// <example>52.3F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("legal_index")]
        public double? LegalIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Multilingual Index score, as a fraction from 0 to 1: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 0.82F
        /// </summary>
        /// <example>0.82F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("multilingual_index")]
        public double? MultilingualIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Openness Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 33.3F
        /// </summary>
        /// <example>33.3F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("openness_index")]
        public double? OpennessIndex { get; set; }

        /// <summary>
        /// Artificial Analysis Strategy &amp; Ops Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 61.7F
        /// </summary>
        /// <example>61.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy_and_ops_index")]
        public double? StrategyAndOpsIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AABenchmarkEntry" /> class.
        /// </summary>
        /// <param name="cyberIndex">
        /// Artificial Analysis Cyber Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 36.4F
        /// </param>
        /// <param name="decisionIndex">
        /// Artificial Analysis Decision Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Published for decision models and for the language models Artificial Analysis evaluates on decision tasks. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 75.7F
        /// </param>
        /// <param name="economicsIndex">
        /// Artificial Analysis Economics Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 57.2F
        /// </param>
        /// <param name="engineeringIndex">
        /// Artificial Analysis Engineering Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 60.4F
        /// </param>
        /// <param name="financeAndAccountingIndex">
        /// Artificial Analysis Finance &amp; Accounting Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 58.1F
        /// </param>
        /// <param name="healthcareAndMedicalIndex">
        /// Artificial Analysis Healthcare &amp; Medical Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 56.9F
        /// </param>
        /// <param name="intelligenceIndex">
        /// Artificial Analysis Intelligence Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 71.4F
        /// </param>
        /// <param name="legalIndex">
        /// Artificial Analysis Legal Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 52.3F
        /// </param>
        /// <param name="multilingualIndex">
        /// Artificial Analysis Multilingual Index score, as a fraction from 0 to 1: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 0.82F
        /// </param>
        /// <param name="opennessIndex">
        /// Artificial Analysis Openness Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 33.3F
        /// </param>
        /// <param name="strategyAndOpsIndex">
        /// Artificial Analysis Strategy &amp; Ops Index score, on a 0-100 scale: the model's best across the configurations Artificial Analysis evaluated. Higher is better. One of the six Artificial Analysis Capability Indexes. Null when Artificial Analysis has not published a score for the model.<br/>
        /// Example: 61.7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AABenchmarkEntry(
            double? cyberIndex,
            double? decisionIndex,
            double? economicsIndex,
            double? engineeringIndex,
            double? financeAndAccountingIndex,
            double? healthcareAndMedicalIndex,
            double? intelligenceIndex,
            double? legalIndex,
            double? multilingualIndex,
            double? opennessIndex,
            double? strategyAndOpsIndex)
        {
            this.CyberIndex = cyberIndex;
            this.DecisionIndex = decisionIndex;
            this.EconomicsIndex = economicsIndex;
            this.EngineeringIndex = engineeringIndex;
            this.FinanceAndAccountingIndex = financeAndAccountingIndex;
            this.HealthcareAndMedicalIndex = healthcareAndMedicalIndex;
            this.IntelligenceIndex = intelligenceIndex;
            this.LegalIndex = legalIndex;
            this.MultilingualIndex = multilingualIndex;
            this.OpennessIndex = opennessIndex;
            this.StrategyAndOpsIndex = strategyAndOpsIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AABenchmarkEntry" /> class.
        /// </summary>
        public AABenchmarkEntry()
        {
        }

    }
}