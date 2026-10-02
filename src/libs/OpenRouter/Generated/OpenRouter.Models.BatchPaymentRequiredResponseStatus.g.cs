
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BatchPaymentRequiredResponseStatus : global::System.IEquatable<BatchPaymentRequiredResponseStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchPaymentRequiredResponseStatus(string value)
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
        public static BatchPaymentRequiredResponseStatus Cancelled { get; } = new("cancelled");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus Cancelling { get; } = new("cancelling");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus Expired { get; } = new("expired");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus Finalizing { get; } = new("finalizing");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus Validating { get; } = new("validating");
        /// <summary>
        ///
        /// </summary>
        public static BatchPaymentRequiredResponseStatus FromValue(string value)
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
                _ => new BatchPaymentRequiredResponseStatus(value),
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
        public bool Equals(BatchPaymentRequiredResponseStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchPaymentRequiredResponseStatus other && Equals(other);
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
        public static bool operator ==(BatchPaymentRequiredResponseStatus left, BatchPaymentRequiredResponseStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchPaymentRequiredResponseStatus left, BatchPaymentRequiredResponseStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchPaymentRequiredResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchPaymentRequiredResponseStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchPaymentRequiredResponseStatus? ToEnum(string value)
        {
            return BatchPaymentRequiredResponseStatus.FromValue(value);
        }
    }
}