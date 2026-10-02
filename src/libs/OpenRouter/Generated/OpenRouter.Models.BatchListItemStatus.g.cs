
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BatchListItemStatus : global::System.IEquatable<BatchListItemStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchListItemStatus(string value)
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
        public static BatchListItemStatus Cancelled { get; } = new("cancelled");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus Cancelling { get; } = new("cancelling");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus Expired { get; } = new("expired");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus Finalizing { get; } = new("finalizing");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus Validating { get; } = new("validating");
        /// <summary>
        ///
        /// </summary>
        public static BatchListItemStatus FromValue(string value)
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
                _ => new BatchListItemStatus(value),
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
        public bool Equals(BatchListItemStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchListItemStatus other && Equals(other);
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
        public static bool operator ==(BatchListItemStatus left, BatchListItemStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchListItemStatus left, BatchListItemStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchListItemStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchListItemStatus? ToEnum(string value)
        {
            return BatchListItemStatus.FromValue(value);
        }
    }
}