
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Filter results by task type. For Artificial Analysis, maps to the corresponding index. For Design Arena, maps to the matching category. `search` returns OpenRouter search benchmark results only.<br/>
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
        ///
        /// </summary>
        public static GetBenchmarksTaskType Agentic { get; } = new("agentic");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Coding { get; } = new("coding");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Intelligence { get; } = new("intelligence");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksTaskType Search { get; } = new("search");
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
                "intelligence" => Intelligence,
                "search" => Search,
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
            "intelligence" => true,
            "search" => true,
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