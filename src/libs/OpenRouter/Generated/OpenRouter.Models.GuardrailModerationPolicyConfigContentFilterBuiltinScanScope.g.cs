
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GuardrailModerationPolicyConfigContentFilterBuiltinScanScope : global::System.IEquatable<GuardrailModerationPolicyConfigContentFilterBuiltinScanScope>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailModerationPolicyConfigContentFilterBuiltinScanScope(string value)
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
        public static GuardrailModerationPolicyConfigContentFilterBuiltinScanScope AllMessages { get; } = new("all_messages");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterBuiltinScanScope UserOnly { get; } = new("user_only");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterBuiltinScanScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "all_messages" => AllMessages,
                "user_only" => UserOnly,
                _ => new GuardrailModerationPolicyConfigContentFilterBuiltinScanScope(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "all_messages" => true,
            "user_only" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GuardrailModerationPolicyConfigContentFilterBuiltinScanScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailModerationPolicyConfigContentFilterBuiltinScanScope other && Equals(other);
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
        public static bool operator ==(GuardrailModerationPolicyConfigContentFilterBuiltinScanScope left, GuardrailModerationPolicyConfigContentFilterBuiltinScanScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailModerationPolicyConfigContentFilterBuiltinScanScope left, GuardrailModerationPolicyConfigContentFilterBuiltinScanScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailModerationPolicyConfigContentFilterBuiltinScanScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailModerationPolicyConfigContentFilterBuiltinScanScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterBuiltinScanScope? ToEnum(string value)
        {
            return GuardrailModerationPolicyConfigContentFilterBuiltinScanScope.FromValue(value);
        }
    }
}