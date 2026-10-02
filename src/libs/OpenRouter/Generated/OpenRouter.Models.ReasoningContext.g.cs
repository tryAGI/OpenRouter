
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.<br/>
    /// Example: all_turns
    /// </summary>
    public readonly partial struct ReasoningContext : global::System.IEquatable<ReasoningContext>
    {
        /// <summary>
        ///
        /// </summary>
        public ReasoningContext(string value)
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
        public static ReasoningContext AllTurns { get; } = new("all_turns");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningContext Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningContext CurrentTurn { get; } = new("current_turn");
        /// <summary>
        ///
        /// </summary>
        public static ReasoningContext FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "all_turns" => AllTurns,
                "auto" => Auto,
                "current_turn" => CurrentTurn,
                _ => new ReasoningContext(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "all_turns" => true,
            "auto" => true,
            "current_turn" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ReasoningContext other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningContext other && Equals(other);
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
        public static bool operator ==(ReasoningContext left, ReasoningContext right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningContext left, ReasoningContext right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningContextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningContext value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningContext? ToEnum(string value)
        {
            return ReasoningContext.FromValue(value);
        }
    }
}