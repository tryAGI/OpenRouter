
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputCustomToolCallItemStatus : global::System.IEquatable<OutputCustomToolCallItemStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputCustomToolCallItemStatus(string value)
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
        public static OutputCustomToolCallItemStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static OutputCustomToolCallItemStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static OutputCustomToolCallItemStatus Incomplete { get; } = new("incomplete");
        /// <summary>
        ///
        /// </summary>
        public static OutputCustomToolCallItemStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                _ => new OutputCustomToolCallItemStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completed" => true,
            "in_progress" => true,
            "incomplete" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputCustomToolCallItemStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputCustomToolCallItemStatus other && Equals(other);
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
        public static bool operator ==(OutputCustomToolCallItemStatus left, OutputCustomToolCallItemStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputCustomToolCallItemStatus left, OutputCustomToolCallItemStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCustomToolCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCustomToolCallItemStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCustomToolCallItemStatus? ToEnum(string value)
        {
            return OutputCustomToolCallItemStatus.FromValue(value);
        }
    }
}