
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Filter results by task type. Every value except `search` names the Artificial Analysis index of the same name and returns only models scored on it, best first (`coding` and `agentic` are deprecated: Artificial Analysis has retired those indexes). Design Arena answers only `coding`, `intelligence` and `agentic`, and OpenRouter's own evals only `intelligence` and `agentic`. `search` returns OpenRouter search benchmark results only.<br/>
    /// Example: coding
    /// </summary>
    public readonly partial struct GetBenchmarksTaskType : global::System.IEquatable<GetBenchmarksTaskType>
    {
        /// <summary>
        ///
        /// </summary>
        public GetBenchmarksTaskType(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Artificial Analysis has retired those indexes). Design Arena answers only `coding`, `intelligence` and `agentic`, and OpenRouter's own evals only `intelligence` and `agentic`. `search` returns OpenRouter search benchmark results only.
        /// </summary>
        public static GetBenchmarksTaskType Agentic { get; } = new("agentic");

        /// <summary>
        /// Artificial Analysis has retired those indexes). Design Arena answers only `coding`, `intelligence` and `agentic`, and OpenRouter's own evals only `intelligence` and `agentic`. `search` returns OpenRouter search benchmark results only.
        /// </summary>
        public static GetBenchmarksTaskType Coding { get; } = new("coding");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Cyber { get; } = new("cyber");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Decision { get; } = new("decision");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Economics { get; } = new("economics");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Engineering { get; } = new("engineering");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType FinanceAndAccounting { get; } = new("finance-and-accounting");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType HealthcareAndMedical { get; } = new("healthcare-and-medical");

        /// <summary>
        /// Artificial Analysis has retired those indexes). Design Arena answers only `coding`, `intelligence` and `agentic`, and OpenRouter's own evals only `intelligence` and `agentic`. `search` returns OpenRouter search benchmark results only.
        /// </summary>
        public static GetBenchmarksTaskType Intelligence { get; } = new("intelligence");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Legal { get; } = new("legal");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Multilingual { get; } = new("multilingual");

        /// <summary>
        /// Artificial Analysis has retired those indexes). Design Arena answers only `coding`, `intelligence` and `agentic`, and OpenRouter's own evals only `intelligence` and `agentic`. `search` returns OpenRouter search benchmark results only.
        /// </summary>
        public static GetBenchmarksTaskType Search { get; } = new("search");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType StrategyAndOps { get; } = new("strategy-and-ops");
        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "agentic" => Agentic,
                "coding" => Coding,
                "cyber" => Cyber,
                "decision" => Decision,
                "economics" => Economics,
                "engineering" => Engineering,
                "finance-and-accounting" => FinanceAndAccounting,
                "healthcare-and-medical" => HealthcareAndMedical,
                "intelligence" => Intelligence,
                "legal" => Legal,
                "multilingual" => Multilingual,
                "search" => Search,
                "strategy-and-ops" => StrategyAndOps,
                _ => new GetBenchmarksTaskType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "agentic" => true,
            "coding" => true,
            "cyber" => true,
            "decision" => true,
            "economics" => true,
            "engineering" => true,
            "finance-and-accounting" => true,
            "healthcare-and-medical" => true,
            "intelligence" => true,
            "legal" => true,
            "multilingual" => true,
            "search" => true,
            "strategy-and-ops" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetBenchmarksTaskType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetBenchmarksTaskType other && Equals(other);
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
        public static bool operator ==(GetBenchmarksTaskType left, GetBenchmarksTaskType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetBenchmarksTaskType left, GetBenchmarksTaskType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBenchmarksTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBenchmarksTaskType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBenchmarksTaskType? ToEnum(string value)
        {
            return GetBenchmarksTaskType.FromValue(value);
        }
    }
}