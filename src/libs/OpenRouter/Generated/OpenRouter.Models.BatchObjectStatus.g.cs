
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BatchObjectStatus : global::System.IEquatable<BatchObjectStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchObjectStatus(string value)
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
        public static BatchObjectStatus Cancelled { get; } = new("cancelled");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus Cancelling { get; } = new("cancelling");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus Expired { get; } = new("expired");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus Finalizing { get; } = new("finalizing");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus Validating { get; } = new("validating");
        /// <summary>
        ///
        /// </summary>
        public static BatchObjectStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cancelled" => Cancelled,
                "cancelling" => Cancelling,
                "completed" => Completed,
                "expired" => Expired,
                "failed" => Failed,
                "finalizing" => Finalizing,
                "in_progress" => InProgress,
                "validating" => Validating,
                _ => new BatchObjectStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cancelled" => true,
            "cancelling" => true,
            "completed" => true,
            "expired" => true,
            "failed" => true,
            "finalizing" => true,
            "in_progress" => true,
            "validating" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BatchObjectStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchObjectStatus other && Equals(other);
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
        public static bool operator ==(BatchObjectStatus left, BatchObjectStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchObjectStatus left, BatchObjectStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectStatus? ToEnum(string value)
        {
            return BatchObjectStatus.FromValue(value);
        }
    }
}