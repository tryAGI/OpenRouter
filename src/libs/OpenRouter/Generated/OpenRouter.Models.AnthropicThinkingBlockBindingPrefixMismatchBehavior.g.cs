
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicThinkingBlockBindingPrefixMismatchBehavior : global::System.IEquatable<AnthropicThinkingBlockBindingPrefixMismatchBehavior>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicThinkingBlockBindingPrefixMismatchBehavior(string value)
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
        public static AnthropicThinkingBlockBindingPrefixMismatchBehavior DropBlock { get; } = new("drop_block");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingBlockBindingPrefixMismatchBehavior Error { get; } = new("error");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingBlockBindingPrefixMismatchBehavior FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "drop_block" => DropBlock,
                "error" => Error,
                _ => new AnthropicThinkingBlockBindingPrefixMismatchBehavior(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "drop_block" => true,
            "error" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicThinkingBlockBindingPrefixMismatchBehavior other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicThinkingBlockBindingPrefixMismatchBehavior other && Equals(other);
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
        public static bool operator ==(AnthropicThinkingBlockBindingPrefixMismatchBehavior left, AnthropicThinkingBlockBindingPrefixMismatchBehavior right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicThinkingBlockBindingPrefixMismatchBehavior left, AnthropicThinkingBlockBindingPrefixMismatchBehavior right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingBlockBindingPrefixMismatchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingBlockBindingPrefixMismatchBehavior value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingBlockBindingPrefixMismatchBehavior? ToEnum(string value)
        {
            return AnthropicThinkingBlockBindingPrefixMismatchBehavior.FromValue(value);
        }
    }
}