
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GuardrailModerationPolicyConfigContentFilterAction : global::System.IEquatable<GuardrailModerationPolicyConfigContentFilterAction>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailModerationPolicyConfigContentFilterAction(string value)
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
        public static GuardrailModerationPolicyConfigContentFilterAction Block { get; } = new("block");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterAction Flag { get; } = new("flag");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterAction Redact { get; } = new("redact");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterAction FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "block" => Block,
                "flag" => Flag,
                "redact" => Redact,
                _ => new GuardrailModerationPolicyConfigContentFilterAction(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "block" => true,
            "flag" => true,
            "redact" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GuardrailModerationPolicyConfigContentFilterAction other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailModerationPolicyConfigContentFilterAction other && Equals(other);
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
        public static bool operator ==(GuardrailModerationPolicyConfigContentFilterAction left, GuardrailModerationPolicyConfigContentFilterAction right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailModerationPolicyConfigContentFilterAction left, GuardrailModerationPolicyConfigContentFilterAction right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailModerationPolicyConfigContentFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailModerationPolicyConfigContentFilterAction value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailModerationPolicyConfigContentFilterAction? ToEnum(string value)
        {
            return GuardrailModerationPolicyConfigContentFilterAction.FromValue(value);
        }
    }
}