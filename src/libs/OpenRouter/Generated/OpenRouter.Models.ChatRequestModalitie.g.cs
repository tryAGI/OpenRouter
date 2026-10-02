
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChatRequestModalitie : global::System.IEquatable<ChatRequestModalitie>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatRequestModalitie(string value)
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
        public static ChatRequestModalitie Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestModalitie Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestModalitie Text { get; } = new("text");
        /// <summary>
        ///
        /// </summary>
        public static ChatRequestModalitie FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "image" => Image,
                "text" => Text,
                _ => new ChatRequestModalitie(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "image" => true,
            "text" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatRequestModalitie other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestModalitie other && Equals(other);
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
        public static bool operator ==(ChatRequestModalitie left, ChatRequestModalitie right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatRequestModalitie left, ChatRequestModalitie right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestModalitie value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestModalitie? ToEnum(string value)
        {
            return ChatRequestModalitie.FromValue(value);
        }
    }
}