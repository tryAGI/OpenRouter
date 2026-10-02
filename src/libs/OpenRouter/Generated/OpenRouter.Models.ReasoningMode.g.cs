
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.<br/>
    /// Example: standard
    /// </summary>
    public readonly partial struct ReasoningMode : global::System.IEquatable<ReasoningMode>
    {
        /// <summary>
        ///
        /// </summary>
        public ReasoningMode(string value)
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
        public static ReasoningMode Pro { get; } = new("pro");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningMode Standard { get; } = new("standard");
        /// <summary>
        ///
        /// </summary>
        public static ReasoningMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "pro" => Pro,
                "standard" => Standard,
                _ => new ReasoningMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "pro" => true,
            "standard" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ReasoningMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningMode other && Equals(other);
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
        public static bool operator ==(ReasoningMode left, ReasoningMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningMode left, ReasoningMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningMode? ToEnum(string value)
        {
            return ReasoningMode.FromValue(value);
        }
    }
}