
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: summarized
    /// </summary>
    public readonly partial struct AnthropicThinkingDisplay : global::System.IEquatable<AnthropicThinkingDisplay>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicThinkingDisplay(string value)
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
        public static AnthropicThinkingDisplay Omitted { get; } = new("omitted");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingDisplay Summarized { get; } = new("summarized");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingDisplay Updates { get; } = new("updates");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingDisplay FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "omitted" => Omitted,
                "summarized" => Summarized,
                "updates" => Updates,
                _ => new AnthropicThinkingDisplay(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "omitted" => true,
            "summarized" => true,
            "updates" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicThinkingDisplay other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicThinkingDisplay other && Equals(other);
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
        public static bool operator ==(AnthropicThinkingDisplay left, AnthropicThinkingDisplay right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicThinkingDisplay left, AnthropicThinkingDisplay right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingDisplayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingDisplay value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingDisplay? ToEnum(string value)
        {
            return AnthropicThinkingDisplay.FromValue(value);
        }
    }
}