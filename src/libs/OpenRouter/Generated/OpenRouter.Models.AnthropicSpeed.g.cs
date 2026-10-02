
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: standard
    /// </summary>
    public readonly partial struct AnthropicSpeed : global::System.IEquatable<AnthropicSpeed>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicSpeed(string value)
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
        public static AnthropicSpeed Fast { get; } = new("fast");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicSpeed Standard { get; } = new("standard");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicSpeed FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "fast" => Fast,
                "standard" => Standard,
                _ => new AnthropicSpeed(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "fast" => true,
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
        public bool Equals(AnthropicSpeed other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicSpeed other && Equals(other);
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
        public static bool operator ==(AnthropicSpeed left, AnthropicSpeed right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicSpeed left, AnthropicSpeed right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicSpeed value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicSpeed? ToEnum(string value)
        {
            return AnthropicSpeed.FromValue(value);
        }
    }
}