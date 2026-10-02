
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlignmentUnavailableCallRecordReason : global::System.IEquatable<AlignmentUnavailableCallRecordReason>
    {
        /// <summary>
        ///
        /// </summary>
        public AlignmentUnavailableCallRecordReason(string value)
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
        public static AlignmentUnavailableCallRecordReason Cut { get; } = new("cut");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentUnavailableCallRecordReason EvaluatorError { get; } = new("evaluator_error");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentUnavailableCallRecordReason MalformedAnswer { get; } = new("malformed_answer");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentUnavailableCallRecordReason TimeLimit { get; } = new("time_limit");
        /// <summary>
        ///
        /// </summary>
        public static AlignmentUnavailableCallRecordReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cut" => Cut,
                "evaluator_error" => EvaluatorError,
                "malformed_answer" => MalformedAnswer,
                "time_limit" => TimeLimit,
                _ => new AlignmentUnavailableCallRecordReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cut" => true,
            "evaluator_error" => true,
            "malformed_answer" => true,
            "time_limit" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AlignmentUnavailableCallRecordReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlignmentUnavailableCallRecordReason other && Equals(other);
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
        public static bool operator ==(AlignmentUnavailableCallRecordReason left, AlignmentUnavailableCallRecordReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlignmentUnavailableCallRecordReason left, AlignmentUnavailableCallRecordReason right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentUnavailableCallRecordReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentUnavailableCallRecordReason value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentUnavailableCallRecordReason? ToEnum(string value)
        {
            return AlignmentUnavailableCallRecordReason.FromValue(value);
        }
    }
}