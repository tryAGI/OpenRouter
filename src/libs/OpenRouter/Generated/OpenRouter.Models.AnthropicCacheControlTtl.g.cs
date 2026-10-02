
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: 5m
    /// </summary>
    public readonly partial struct AnthropicCacheControlTtl : global::System.IEquatable<AnthropicCacheControlTtl>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicCacheControlTtl(string value)
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
        public static AnthropicCacheControlTtl x1h { get; } = new("1h");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicCacheControlTtl x5m { get; } = new("5m");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicCacheControlTtl FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "1h" => x1h,
                "5m" => x5m,
                _ => new AnthropicCacheControlTtl(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "1h" => true,
            "5m" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicCacheControlTtl other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicCacheControlTtl other && Equals(other);
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
        public static bool operator ==(AnthropicCacheControlTtl left, AnthropicCacheControlTtl right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicCacheControlTtl left, AnthropicCacheControlTtl right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCacheControlTtl value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCacheControlTtl? ToEnum(string value)
        {
            return AnthropicCacheControlTtl.FromValue(value);
        }
    }
}