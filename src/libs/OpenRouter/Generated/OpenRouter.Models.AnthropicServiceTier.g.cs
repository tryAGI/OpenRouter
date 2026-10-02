
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: standard
    /// </summary>
    public readonly partial struct AnthropicServiceTier : global::System.IEquatable<AnthropicServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicServiceTier(string value)
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
        public static AnthropicServiceTier Batch { get; } = new("batch");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicServiceTier Standard { get; } = new("standard");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "batch" => Batch,
                "priority" => Priority,
                "standard" => Standard,
                _ => new AnthropicServiceTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "batch" => true,
            "priority" => true,
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
        public bool Equals(AnthropicServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicServiceTier other && Equals(other);
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
        public static bool operator ==(AnthropicServiceTier left, AnthropicServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicServiceTier left, AnthropicServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicServiceTier? ToEnum(string value)
        {
            return AnthropicServiceTier.FromValue(value);
        }
    }
}