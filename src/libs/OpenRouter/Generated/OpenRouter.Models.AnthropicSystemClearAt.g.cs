
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: next_user_message
    /// </summary>
    public readonly partial struct AnthropicSystemClearAt : global::System.IEquatable<AnthropicSystemClearAt>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicSystemClearAt(string value)
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
        public static AnthropicSystemClearAt Never { get; } = new("never");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicSystemClearAt NextUserMessage { get; } = new("next_user_message");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicSystemClearAt FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "never" => Never,
                "next_user_message" => NextUserMessage,
                _ => new AnthropicSystemClearAt(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "never" => true,
            "next_user_message" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicSystemClearAt other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicSystemClearAt other && Equals(other);
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
        public static bool operator ==(AnthropicSystemClearAt left, AnthropicSystemClearAt right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicSystemClearAt left, AnthropicSystemClearAt right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicSystemClearAtExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicSystemClearAt value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicSystemClearAt? ToEnum(string value)
        {
            return AnthropicSystemClearAt.FromValue(value);
        }
    }
}