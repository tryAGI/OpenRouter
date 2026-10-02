
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
    /// Example: newest
    /// </summary>
    public readonly partial struct GetModelsSort : global::System.IEquatable<GetModelsSort>
    {
        /// <summary>
        ///
        /// </summary>
        public GetModelsSort(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort AgenticHighToLow { get; } = new("agentic-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort CodingHighToLow { get; } = new("coding-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort ContextHighToLow { get; } = new("context-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort DesignArenaEloHighToLow { get; } = new("design-arena-elo-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort IntelligenceHighToLow { get; } = new("intelligence-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort LatencyLowToHigh { get; } = new("latency-low-to-high");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort MostPopular { get; } = new("most-popular");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort Newest { get; } = new("newest");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort PricingHighToLow { get; } = new("pricing-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort PricingLowToHigh { get; } = new("pricing-low-to-high");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort ThroughputHighToLow { get; } = new("throughput-high-to-low");

        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        public static GetModelsSort TopWeekly { get; } = new("top-weekly");
        /// <summary>
        ///
        /// </summary>
        public static GetModelsSort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "agentic-high-to-low" => AgenticHighToLow,
                "coding-high-to-low" => CodingHighToLow,
                "context-high-to-low" => ContextHighToLow,
                "design-arena-elo-high-to-low" => DesignArenaEloHighToLow,
                "intelligence-high-to-low" => IntelligenceHighToLow,
                "latency-low-to-high" => LatencyLowToHigh,
                "most-popular" => MostPopular,
                "newest" => Newest,
                "pricing-high-to-low" => PricingHighToLow,
                "pricing-low-to-high" => PricingLowToHigh,
                "throughput-high-to-low" => ThroughputHighToLow,
                "top-weekly" => TopWeekly,
                _ => new GetModelsSort(value),
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
            "design-arena-elo-high-to-low" => true,
            "intelligence-high-to-low" => true,
            "latency-low-to-high" => true,
            "most-popular" => true,
            "newest" => true,
            "pricing-high-to-low" => true,
            "pricing-low-to-high" => true,
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
        public bool Equals(GetModelsSort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetModelsSort other && Equals(other);
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
        public static bool operator ==(GetModelsSort left, GetModelsSort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetModelsSort left, GetModelsSort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsSort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsSort? ToEnum(string value)
        {
            return GetModelsSort.FromValue(value);
        }
    }
}