
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// A batch status that is durably represented by the list data source. `finalizing` and `cancelling` are not accepted because stored jobs collapse those phases into `in_progress`.<br/>
    /// Example: completed
    /// </summary>
    public readonly partial struct BatchListStatus : global::System.IEquatable<BatchListStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchListStatus(string value)
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
        public static BatchListStatus Cancelled { get; } = new("cancelled");

        /// <summary>
        ///
        /// </summary>
        public static BatchListStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static BatchListStatus Expired { get; } = new("expired");

        /// <summary>
        ///
        /// </summary>
        public static BatchListStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static BatchListStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static BatchListStatus Validating { get; } = new("validating");
        /// <summary>
        ///
        /// </summary>
        public static BatchListStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cancelled" => Cancelled,
                "completed" => Completed,
                "expired" => Expired,
                "failed" => Failed,
                "in_progress" => InProgress,
                "validating" => Validating,
                _ => new BatchListStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cancelled" => true,
            "completed" => true,
            "expired" => true,
            "failed" => true,
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
        public bool Equals(BatchListStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchListStatus other && Equals(other);
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
        public static bool operator ==(BatchListStatus left, BatchListStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchListStatus left, BatchListStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchListStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchListStatus? ToEnum(string value)
        {
            return BatchListStatus.FromValue(value);
        }
    }
}