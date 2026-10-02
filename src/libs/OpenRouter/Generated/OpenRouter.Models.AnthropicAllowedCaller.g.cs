
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicAllowedCaller : global::System.IEquatable<AnthropicAllowedCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicAllowedCaller(string value)
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
        public static AnthropicAllowedCaller CodeExecution20250825 { get; } = new("code_execution_20250825");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicAllowedCaller CodeExecution20260120 { get; } = new("code_execution_20260120");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicAllowedCaller Direct { get; } = new("direct");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicAllowedCaller FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "code_execution_20250825" => CodeExecution20250825,
                "code_execution_20260120" => CodeExecution20260120,
                "direct" => Direct,
                _ => new AnthropicAllowedCaller(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "code_execution_20250825" => true,
            "code_execution_20260120" => true,
            "direct" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicAllowedCaller other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicAllowedCaller other && Equals(other);
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
        public static bool operator ==(AnthropicAllowedCaller left, AnthropicAllowedCaller right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicAllowedCaller left, AnthropicAllowedCaller right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicAllowedCaller value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicAllowedCaller? ToEnum(string value)
        {
            return AnthropicAllowedCaller.FromValue(value);
        }
    }
}