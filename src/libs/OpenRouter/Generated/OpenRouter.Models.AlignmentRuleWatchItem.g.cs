
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlignmentRuleWatchItem : global::System.IEquatable<AlignmentRuleWatchItem>
    {
        /// <summary>
        ///
        /// </summary>
        public AlignmentRuleWatchItem(string value)
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
        public static AlignmentRuleWatchItem Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentRuleWatchItem Content { get; } = new("content");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentRuleWatchItem Images { get; } = new("images");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentRuleWatchItem Refusal { get; } = new("refusal");

        /// <summary>
        ///
        /// </summary>
        public static AlignmentRuleWatchItem ToolCalls { get; } = new("tool_calls");
        /// <summary>
        ///
        /// </summary>
        public static AlignmentRuleWatchItem FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "content" => Content,
                "images" => Images,
                "refusal" => Refusal,
                "tool_calls" => ToolCalls,
                _ => new AlignmentRuleWatchItem(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "content" => true,
            "images" => true,
            "refusal" => true,
            "tool_calls" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AlignmentRuleWatchItem other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlignmentRuleWatchItem other && Equals(other);
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
        public static bool operator ==(AlignmentRuleWatchItem left, AlignmentRuleWatchItem right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlignmentRuleWatchItem left, AlignmentRuleWatchItem right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentRuleWatchItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentRuleWatchItem value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentRuleWatchItem? ToEnum(string value)
        {
            return AlignmentRuleWatchItem.FromValue(value);
        }
    }
}