
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Lifecycle state of an `apply_patch_call` output item.<br/>
    /// Example: completed
    /// </summary>
    public readonly partial struct ApplyPatchCallStatus : global::System.IEquatable<ApplyPatchCallStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ApplyPatchCallStatus(string value)
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
        public static ApplyPatchCallStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallStatus InProgress { get; } = new("in_progress");
        /// <summary>
        ///
        /// </summary>
        public static ApplyPatchCallStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "in_progress" => InProgress,
                _ => new ApplyPatchCallStatus(value),
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
        public bool Equals(ApplyPatchCallStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchCallStatus other && Equals(other);
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
        public static bool operator ==(ApplyPatchCallStatus left, ApplyPatchCallStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ApplyPatchCallStatus left, ApplyPatchCallStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallStatus? ToEnum(string value)
        {
            return ApplyPatchCallStatus.FromValue(value);
        }
    }
}