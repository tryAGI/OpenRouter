
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Outcome for one deletion target: `deleted` (removed), `unsupported` (the provider has no batch-delete API; supported file cleanup still runs), or `not_applicable` (the batch never reached that target).<br/>
    /// Example: deleted
    /// </summary>
    public readonly partial struct BatchDeletionOutcome : global::System.IEquatable<BatchDeletionOutcome>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchDeletionOutcome(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `deleted` (removed), `unsupported` (the provider has no batch-delete API; supported file cleanup still runs), or `not_applicable` (the batch never reached that target).
        /// </summary>
        public static BatchDeletionOutcome Deleted { get; } = new("deleted");

        /// <summary>
        /// `deleted` (removed), `unsupported` (the provider has no batch-delete API; supported file cleanup still runs), or `not_applicable` (the batch never reached that target).
        /// </summary>
        public static BatchDeletionOutcome NotApplicable { get; } = new("not_applicable");

        /// <summary>
        /// `deleted` (removed), `unsupported` (the provider has no batch-delete API; supported file cleanup still runs), or `not_applicable` (the batch never reached that target).
        /// </summary>
        public static BatchDeletionOutcome Unsupported { get; } = new("unsupported");
        /// <summary>
        ///
        /// </summary>
        public static BatchDeletionOutcome FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "deleted" => Deleted,
                "not_applicable" => NotApplicable,
                "unsupported" => Unsupported,
                _ => new BatchDeletionOutcome(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "deleted" => true,
            "not_applicable" => true,
            "unsupported" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BatchDeletionOutcome other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchDeletionOutcome other && Equals(other);
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
        public static bool operator ==(BatchDeletionOutcome left, BatchDeletionOutcome right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchDeletionOutcome left, BatchDeletionOutcome right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchDeletionOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchDeletionOutcome value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchDeletionOutcome? ToEnum(string value)
        {
            return BatchDeletionOutcome.FromValue(value);
        }
    }
}