
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputItemCodeInterpreterCallStatus : global::System.IEquatable<OutputItemCodeInterpreterCallStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputItemCodeInterpreterCallStatus(string value)
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
        public static OutputItemCodeInterpreterCallStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemCodeInterpreterCallStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemCodeInterpreterCallStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemCodeInterpreterCallStatus Incomplete { get; } = new("incomplete");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemCodeInterpreterCallStatus Interpreting { get; } = new("interpreting");
        /// <summary>
        ///
        /// </summary>
        public static OutputItemCodeInterpreterCallStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "failed" => Failed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                "interpreting" => Interpreting,
                _ => new OutputItemCodeInterpreterCallStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completed" => true,
            "failed" => true,
            "in_progress" => true,
            "incomplete" => true,
            "interpreting" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputItemCodeInterpreterCallStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItemCodeInterpreterCallStatus other && Equals(other);
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
        public static bool operator ==(OutputItemCodeInterpreterCallStatus left, OutputItemCodeInterpreterCallStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputItemCodeInterpreterCallStatus left, OutputItemCodeInterpreterCallStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemCodeInterpreterCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemCodeInterpreterCallStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemCodeInterpreterCallStatus? ToEnum(string value)
        {
            return OutputItemCodeInterpreterCallStatus.FromValue(value);
        }
    }
}