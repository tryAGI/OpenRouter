
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Policy type the assignment is read or changed for<br/>
    /// Example: budget
    /// </summary>
    public readonly partial struct ChangeGuardrailPolicyAssignmentRequestPolicyType : global::System.IEquatable<ChangeGuardrailPolicyAssignmentRequestPolicyType>
    {
        /// <summary>
        ///
        /// </summary>
        public ChangeGuardrailPolicyAssignmentRequestPolicyType(string value)
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
        public static ChangeGuardrailPolicyAssignmentRequestPolicyType Budget { get; } = new("budget");

        /// <summary>
        ///
        /// </summary>
        public static ChangeGuardrailPolicyAssignmentRequestPolicyType ModelAvailability { get; } = new("model_availability");

        /// <summary>
        ///
        /// </summary>
        public static ChangeGuardrailPolicyAssignmentRequestPolicyType Moderation { get; } = new("moderation");

        /// <summary>
        ///
        /// </summary>
        public static ChangeGuardrailPolicyAssignmentRequestPolicyType RateLimit { get; } = new("rate_limit");
        /// <summary>
        ///
        /// </summary>
        public static ChangeGuardrailPolicyAssignmentRequestPolicyType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "budget" => Budget,
                "model_availability" => ModelAvailability,
                "moderation" => Moderation,
                "rate_limit" => RateLimit,
                _ => new ChangeGuardrailPolicyAssignmentRequestPolicyType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "budget" => true,
            "model_availability" => true,
            "moderation" => true,
            "rate_limit" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChangeGuardrailPolicyAssignmentRequestPolicyType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChangeGuardrailPolicyAssignmentRequestPolicyType other && Equals(other);
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
        public static bool operator ==(ChangeGuardrailPolicyAssignmentRequestPolicyType left, ChangeGuardrailPolicyAssignmentRequestPolicyType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChangeGuardrailPolicyAssignmentRequestPolicyType left, ChangeGuardrailPolicyAssignmentRequestPolicyType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChangeGuardrailPolicyAssignmentRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChangeGuardrailPolicyAssignmentRequestPolicyType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChangeGuardrailPolicyAssignmentRequestPolicyType? ToEnum(string value)
        {
            return ChangeGuardrailPolicyAssignmentRequestPolicyType.FromValue(value);
        }
    }
}