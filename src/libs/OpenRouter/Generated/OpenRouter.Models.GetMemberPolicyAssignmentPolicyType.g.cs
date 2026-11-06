
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Policy type the assignment is read or changed for<br/>
    /// Example: budget
    /// </summary>
    public readonly partial struct GetMemberPolicyAssignmentPolicyType : global::System.IEquatable<GetMemberPolicyAssignmentPolicyType>
    {
        /// <summary>
        ///
        /// </summary>
        public GetMemberPolicyAssignmentPolicyType(string value)
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
        public static GetMemberPolicyAssignmentPolicyType Budget { get; } = new("budget");

        /// <summary>
        ///
        /// </summary>
        public static GetMemberPolicyAssignmentPolicyType ModelAvailability { get; } = new("model_availability");

        /// <summary>
        ///
        /// </summary>
        public static GetMemberPolicyAssignmentPolicyType Moderation { get; } = new("moderation");

        /// <summary>
        ///
        /// </summary>
        public static GetMemberPolicyAssignmentPolicyType RateLimit { get; } = new("rate_limit");
        /// <summary>
        ///
        /// </summary>
        public static GetMemberPolicyAssignmentPolicyType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "budget" => Budget,
                "model_availability" => ModelAvailability,
                "moderation" => Moderation,
                "rate_limit" => RateLimit,
                _ => new GetMemberPolicyAssignmentPolicyType(value),
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
        public bool Equals(GetMemberPolicyAssignmentPolicyType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetMemberPolicyAssignmentPolicyType other && Equals(other);
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
        public static bool operator ==(GetMemberPolicyAssignmentPolicyType left, GetMemberPolicyAssignmentPolicyType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetMemberPolicyAssignmentPolicyType left, GetMemberPolicyAssignmentPolicyType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMemberPolicyAssignmentPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMemberPolicyAssignmentPolicyType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMemberPolicyAssignmentPolicyType? ToEnum(string value)
        {
            return GetMemberPolicyAssignmentPolicyType.FromValue(value);
        }
    }
}