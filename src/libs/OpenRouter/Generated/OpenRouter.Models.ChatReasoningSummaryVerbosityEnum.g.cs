
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: concise
    /// </summary>
    public readonly partial struct ChatReasoningSummaryVerbosityEnum : global::System.IEquatable<ChatReasoningSummaryVerbosityEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatReasoningSummaryVerbosityEnum(string value)
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
        public static ChatReasoningSummaryVerbosityEnum Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ChatReasoningSummaryVerbosityEnum Concise { get; } = new("concise");

        /// <summary>
        ///
        /// </summary>
        public static ChatReasoningSummaryVerbosityEnum Detailed { get; } = new("detailed");
        /// <summary>
        ///
        /// </summary>
        public static ChatReasoningSummaryVerbosityEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "concise" => Concise,
                "detailed" => Detailed,
                _ => new ChatReasoningSummaryVerbosityEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "concise" => true,
            "detailed" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatReasoningSummaryVerbosityEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatReasoningSummaryVerbosityEnum other && Equals(other);
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
        public static bool operator ==(ChatReasoningSummaryVerbosityEnum left, ChatReasoningSummaryVerbosityEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatReasoningSummaryVerbosityEnum left, ChatReasoningSummaryVerbosityEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatReasoningSummaryVerbosityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatReasoningSummaryVerbosityEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatReasoningSummaryVerbosityEnum? ToEnum(string value)
        {
            return ChatReasoningSummaryVerbosityEnum.FromValue(value);
        }
    }
}