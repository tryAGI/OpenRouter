
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which message roles to scan for prompt injection. Only applies to the regex-prompt-injection builtin. Defaults to all_messages.<br/>
    /// Example: user_only
    /// </summary>
    public readonly partial struct PromptInjectionScanScope : global::System.IEquatable<PromptInjectionScanScope>
    {
        /// <summary>
        ///
        /// </summary>
        public PromptInjectionScanScope(string value)
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
        public static PromptInjectionScanScope AllMessages { get; } = new("all_messages");

        /// <summary>
        ///
        /// </summary>
        public static PromptInjectionScanScope UserOnly { get; } = new("user_only");
        /// <summary>
        ///
        /// </summary>
        public static PromptInjectionScanScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "all_messages" => AllMessages,
                "user_only" => UserOnly,
                _ => new PromptInjectionScanScope(value),
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
        public bool Equals(PromptInjectionScanScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptInjectionScanScope other && Equals(other);
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
        public static bool operator ==(PromptInjectionScanScope left, PromptInjectionScanScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptInjectionScanScope left, PromptInjectionScanScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptInjectionScanScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptInjectionScanScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptInjectionScanScope? ToEnum(string value)
        {
            return PromptInjectionScanScope.FromValue(value);
        }
    }
}