
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Deprecated: legacy alias of prefix_mismatch_behavior. Send only one of the two.
    /// </summary>
    public readonly partial struct AnthropicThinkingBlockBindingMismatchBehavior : global::System.IEquatable<AnthropicThinkingBlockBindingMismatchBehavior>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicThinkingBlockBindingMismatchBehavior(string value)
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
        public static AnthropicThinkingBlockBindingMismatchBehavior DropBlock { get; } = new("drop_block");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingBlockBindingMismatchBehavior Error { get; } = new("error");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicThinkingBlockBindingMismatchBehavior FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "drop_block" => DropBlock,
                "error" => Error,
                _ => new AnthropicThinkingBlockBindingMismatchBehavior(value),
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
        public bool Equals(AnthropicThinkingBlockBindingMismatchBehavior other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicThinkingBlockBindingMismatchBehavior other && Equals(other);
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
        public static bool operator ==(AnthropicThinkingBlockBindingMismatchBehavior left, AnthropicThinkingBlockBindingMismatchBehavior right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicThinkingBlockBindingMismatchBehavior left, AnthropicThinkingBlockBindingMismatchBehavior right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingBlockBindingMismatchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingBlockBindingMismatchBehavior value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingBlockBindingMismatchBehavior? ToEnum(string value)
        {
            return AnthropicThinkingBlockBindingMismatchBehavior.FromValue(value);
        }
    }
}