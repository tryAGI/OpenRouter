
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputItemApplyPatchCallStatus : global::System.IEquatable<OutputItemApplyPatchCallStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputItemApplyPatchCallStatus(string value)
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
        public static OutputItemApplyPatchCallStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static OutputItemApplyPatchCallStatus InProgress { get; } = new("in_progress");
        /// <summary>
        ///
        /// </summary>
        public static OutputItemApplyPatchCallStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "in_progress" => InProgress,
                _ => new OutputItemApplyPatchCallStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completed" => true,
            "in_progress" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputItemApplyPatchCallStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItemApplyPatchCallStatus other && Equals(other);
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
        public static bool operator ==(OutputItemApplyPatchCallStatus left, OutputItemApplyPatchCallStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputItemApplyPatchCallStatus left, OutputItemApplyPatchCallStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemApplyPatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemApplyPatchCallStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemApplyPatchCallStatus? ToEnum(string value)
        {
            return OutputItemApplyPatchCallStatus.FromValue(value);
        }
    }
}