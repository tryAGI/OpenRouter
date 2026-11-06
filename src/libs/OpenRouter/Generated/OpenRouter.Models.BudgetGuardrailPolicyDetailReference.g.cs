
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `legacy_mapping` when the policy is synced from a v1 guardrail, `account_default` when it is an account-wide default, otherwise `null`<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public readonly partial struct BudgetGuardrailPolicyDetailReference : global::System.IEquatable<BudgetGuardrailPolicyDetailReference>
    {
        /// <summary>
        ///
        /// </summary>
        public BudgetGuardrailPolicyDetailReference(string value)
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
        public static BudgetGuardrailPolicyDetailReference AccountDefault { get; } = new("account_default");

        /// <summary>
        ///
        /// </summary>
        public static BudgetGuardrailPolicyDetailReference LegacyMapping { get; } = new("legacy_mapping");
        /// <summary>
        ///
        /// </summary>
        public static BudgetGuardrailPolicyDetailReference FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "account_default" => AccountDefault,
                "legacy_mapping" => LegacyMapping,
                _ => new BudgetGuardrailPolicyDetailReference(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "account_default" => true,
            "legacy_mapping" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BudgetGuardrailPolicyDetailReference other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BudgetGuardrailPolicyDetailReference other && Equals(other);
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
        public static bool operator ==(BudgetGuardrailPolicyDetailReference left, BudgetGuardrailPolicyDetailReference right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BudgetGuardrailPolicyDetailReference left, BudgetGuardrailPolicyDetailReference right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetGuardrailPolicyDetailReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetGuardrailPolicyDetailReference value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetGuardrailPolicyDetailReference? ToEnum(string value)
        {
            return BudgetGuardrailPolicyDetailReference.FromValue(value);
        }
    }
}