
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
    /// </summary>
    public enum ModelsGetParametersSort
    {
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        ContextHighToLow,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        DesignArenaEloHighToLow,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        IntelligenceHighToLow,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        LatencyLowToHigh,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        MostPopular,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        Newest,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        PricingHighToLow,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        PricingLowToHigh,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        ThroughputHighToLow,
        /// <summary>
        /// pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </summary>
        TopWeekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsGetParametersSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsGetParametersSort value)
        {
            return value switch
            {
                ModelsGetParametersSort.ContextHighToLow => "context-high-to-low",
                ModelsGetParametersSort.DesignArenaEloHighToLow => "design-arena-elo-high-to-low",
                ModelsGetParametersSort.IntelligenceHighToLow => "intelligence-high-to-low",
                ModelsGetParametersSort.LatencyLowToHigh => "latency-low-to-high",
                ModelsGetParametersSort.MostPopular => "most-popular",
                ModelsGetParametersSort.Newest => "newest",
                ModelsGetParametersSort.PricingHighToLow => "pricing-high-to-low",
                ModelsGetParametersSort.PricingLowToHigh => "pricing-low-to-high",
                ModelsGetParametersSort.ThroughputHighToLow => "throughput-high-to-low",
                ModelsGetParametersSort.TopWeekly => "top-weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsGetParametersSort? ToEnum(string value)
        {
            return value switch
            {
                "context-high-to-low" => ModelsGetParametersSort.ContextHighToLow,
                "design-arena-elo-high-to-low" => ModelsGetParametersSort.DesignArenaEloHighToLow,
                "intelligence-high-to-low" => ModelsGetParametersSort.IntelligenceHighToLow,
                "latency-low-to-high" => ModelsGetParametersSort.LatencyLowToHigh,
                "most-popular" => ModelsGetParametersSort.MostPopular,
                "newest" => ModelsGetParametersSort.Newest,
                "pricing-high-to-low" => ModelsGetParametersSort.PricingHighToLow,
                "pricing-low-to-high" => ModelsGetParametersSort.PricingLowToHigh,
                "throughput-high-to-low" => ModelsGetParametersSort.ThroughputHighToLow,
                "top-weekly" => ModelsGetParametersSort.TopWeekly,
                _ => null,
            };
        }
    }
}