
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.<br/>
    /// Example: newest
    /// </summary>
    public readonly partial struct ListModelsUserSort : global::System.IEquatable<ListModelsUserSort>
    {
        /// <summary>
        ///
        /// </summary>
        public ListModelsUserSort(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort AgenticHighToLow { get; } = new("agentic-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort CodingHighToLow { get; } = new("coding-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort ContextHighToLow { get; } = new("context-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort CyberHighToLow { get; } = new("cyber-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort DecisionHighToLow { get; } = new("decision-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort DesignArenaEloHighToLow { get; } = new("design-arena-elo-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort EconomicsHighToLow { get; } = new("economics-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort EngineeringHighToLow { get; } = new("engineering-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort FinanceAndAccountingHighToLow { get; } = new("finance-and-accounting-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort HealthcareAndMedicalHighToLow { get; } = new("healthcare-and-medical-high-to-low");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort IntelligenceHighToLow { get; } = new("intelligence-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort LatencyLowToHigh { get; } = new("latency-low-to-high");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort LegalHighToLow { get; } = new("legal-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort MostPopular { get; } = new("most-popular");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort MultilingualHighToLow { get; } = new("multilingual-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort Newest { get; } = new("newest");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort OpennessHighToLow { get; } = new("openness-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort PricingHighToLow { get; } = new("pricing-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort PricingLowToHigh { get; } = new("pricing-low-to-high");

        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort StrategyAndOpsHighToLow { get; } = new("strategy-and-ops-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort ThroughputHighToLow { get; } = new("throughput-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static ListModelsUserSort TopWeekly { get; } = new("top-weekly");
        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserSort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "agentic-high-to-low" => AgenticHighToLow,
                "coding-high-to-low" => CodingHighToLow,
                "context-high-to-low" => ContextHighToLow,
                "cyber-high-to-low" => CyberHighToLow,
                "decision-high-to-low" => DecisionHighToLow,
                "design-arena-elo-high-to-low" => DesignArenaEloHighToLow,
                "economics-high-to-low" => EconomicsHighToLow,
                "engineering-high-to-low" => EngineeringHighToLow,
                "finance-and-accounting-high-to-low" => FinanceAndAccountingHighToLow,
                "healthcare-and-medical-high-to-low" => HealthcareAndMedicalHighToLow,
                "intelligence-high-to-low" => IntelligenceHighToLow,
                "latency-low-to-high" => LatencyLowToHigh,
                "legal-high-to-low" => LegalHighToLow,
                "most-popular" => MostPopular,
                "multilingual-high-to-low" => MultilingualHighToLow,
                "newest" => Newest,
                "openness-high-to-low" => OpennessHighToLow,
                "pricing-high-to-low" => PricingHighToLow,
                "pricing-low-to-high" => PricingLowToHigh,
                "strategy-and-ops-high-to-low" => StrategyAndOpsHighToLow,
                "throughput-high-to-low" => ThroughputHighToLow,
                "top-weekly" => TopWeekly,
                _ => new ListModelsUserSort(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "agentic-high-to-low" => true,
            "coding-high-to-low" => true,
            "context-high-to-low" => true,
            "cyber-high-to-low" => true,
            "decision-high-to-low" => true,
            "design-arena-elo-high-to-low" => true,
            "economics-high-to-low" => true,
            "engineering-high-to-low" => true,
            "finance-and-accounting-high-to-low" => true,
            "healthcare-and-medical-high-to-low" => true,
            "intelligence-high-to-low" => true,
            "latency-low-to-high" => true,
            "legal-high-to-low" => true,
            "most-popular" => true,
            "multilingual-high-to-low" => true,
            "newest" => true,
            "openness-high-to-low" => true,
            "pricing-high-to-low" => true,
            "pricing-low-to-high" => true,
            "strategy-and-ops-high-to-low" => true,
            "throughput-high-to-low" => true,
            "top-weekly" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ListModelsUserSort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListModelsUserSort other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListModelsUserSort left, ListModelsUserSort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListModelsUserSort left, ListModelsUserSort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListModelsUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListModelsUserSort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListModelsUserSort? ToEnum(string value)
        {
            return ListModelsUserSort.FromValue(value);
        }
    }
}