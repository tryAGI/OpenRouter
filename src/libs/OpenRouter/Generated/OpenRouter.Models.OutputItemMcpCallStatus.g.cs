
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputItemMcpCallStatus : global::System.IEquatable<OutputItemMcpCallStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputItemMcpCallStatus(string value)
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
        public static OutputItemMcpCallStatus Calling { get; } = new("calling");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemMcpCallStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemMcpCallStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemMcpCallStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemMcpCallStatus Incomplete { get; } = new("incomplete");
        /// <summary>
        ///
        /// </summary>
        public static OutputItemMcpCallStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "calling" => Calling,
                "completed" => Completed,
                "failed" => Failed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                _ => new OutputItemMcpCallStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "calling" => true,
            "completed" => true,
            "failed" => true,
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
        public bool Equals(OutputItemMcpCallStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItemMcpCallStatus other && Equals(other);
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
        public static bool operator ==(OutputItemMcpCallStatus left, OutputItemMcpCallStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputItemMcpCallStatus left, OutputItemMcpCallStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpCallStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpCallStatus? ToEnum(string value)
        {
            return OutputItemMcpCallStatus.FromValue(value);
        }
    }
}