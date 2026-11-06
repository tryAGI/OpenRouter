
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Policy type the assignment is read or changed for<br/>
    /// Example: budget
    /// </summary>
    public readonly partial struct GetApiKeyPolicyAssignmentPolicyType : global::System.IEquatable<GetApiKeyPolicyAssignmentPolicyType>
    {
        /// <summary>
        ///
        /// </summary>
        public GetApiKeyPolicyAssignmentPolicyType(string value)
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
        public static GetApiKeyPolicyAssignmentPolicyType Budget { get; } = new("budget");

        /// <summary>
        ///
        /// </summary>
        public static GetApiKeyPolicyAssignmentPolicyType ModelAvailability { get; } = new("model_availability");

        /// <summary>
        ///
        /// </summary>
        public static GetApiKeyPolicyAssignmentPolicyType Moderation { get; } = new("moderation");

        /// <summary>
        ///
        /// </summary>
        public static GetApiKeyPolicyAssignmentPolicyType RateLimit { get; } = new("rate_limit");
        /// <summary>
        ///
        /// </summary>
        public static GetApiKeyPolicyAssignmentPolicyType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "budget" => Budget,
                "model_availability" => ModelAvailability,
                "moderation" => Moderation,
                "rate_limit" => RateLimit,
                _ => new GetApiKeyPolicyAssignmentPolicyType(value),
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
        public bool Equals(GetApiKeyPolicyAssignmentPolicyType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetApiKeyPolicyAssignmentPolicyType other && Equals(other);
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
        public static bool operator ==(GetApiKeyPolicyAssignmentPolicyType left, GetApiKeyPolicyAssignmentPolicyType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetApiKeyPolicyAssignmentPolicyType left, GetApiKeyPolicyAssignmentPolicyType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetApiKeyPolicyAssignmentPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetApiKeyPolicyAssignmentPolicyType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetApiKeyPolicyAssignmentPolicyType? ToEnum(string value)
        {
            return GetApiKeyPolicyAssignmentPolicyType.FromValue(value);
        }
    }
}