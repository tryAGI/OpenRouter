
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct ChatRequestServiceTier : global::System.IEquatable<ChatRequestServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatRequestServiceTier(string value)
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
        public static ChatRequestServiceTier Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier Default { get; } = new("default");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier Fast { get; } = new("fast");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier Flex { get; } = new("flex");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier Scale { get; } = new("scale");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier Ultrafast { get; } = new("ultrafast");
        /// <summary>
        ///
        /// </summary>
        public static ChatRequestServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "default" => Default,
                "fast" => Fast,
                "flex" => Flex,
                "priority" => Priority,
                "scale" => Scale,
                "ultrafast" => Ultrafast,
                _ => new ChatRequestServiceTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "default" => true,
            "fast" => true,
            "flex" => true,
            "priority" => true,
            "scale" => true,
            "ultrafast" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatRequestServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestServiceTier other && Equals(other);
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
        public static bool operator ==(ChatRequestServiceTier left, ChatRequestServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatRequestServiceTier left, ChatRequestServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestServiceTier? ToEnum(string value)
        {
            return ChatRequestServiceTier.FromValue(value);
        }
    }
}