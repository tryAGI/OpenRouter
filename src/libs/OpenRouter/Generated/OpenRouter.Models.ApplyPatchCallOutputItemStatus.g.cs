
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ApplyPatchCallOutputItemStatus : global::System.IEquatable<ApplyPatchCallOutputItemStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ApplyPatchCallOutputItemStatus(string value)
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
        public static ApplyPatchCallOutputItemStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallOutputItemStatus Failed { get; } = new("failed");
        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallOutputItemStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "failed" => Failed,
                _ => new ApplyPatchCallOutputItemStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completed" => true,
            "failed" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ApplyPatchCallOutputItemStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallOutputItemStatus other && Equals(other);
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
        public static bool operator ==(ApplyPatchCallOutputItemStatus left, ApplyPatchCallOutputItemStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ApplyPatchCallOutputItemStatus left, ApplyPatchCallOutputItemStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOutputItemStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOutputItemStatus? ToEnum(string value)
        {
            return ApplyPatchCallOutputItemStatus.FromValue(value);
        }
    }
}