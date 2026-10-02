
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Image detail level for vision models. `original` is an OpenRouter extension (not in the OpenAI Chat Completions spec) requesting true original-resolution media; it is downgraded to `high` for providers that lack an original-resolution tier.
    /// </summary>
    public readonly partial struct ChatContentImageImageUrlDetail : global::System.IEquatable<ChatContentImageImageUrlDetail>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatContentImageImageUrlDetail(string value)
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
        public static ChatContentImageImageUrlDetail Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ChatContentImageImageUrlDetail High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ChatContentImageImageUrlDetail Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ChatContentImageImageUrlDetail Original { get; } = new("original");
        /// <summary>
        ///
        /// </summary>
        public static ChatContentImageImageUrlDetail FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "high" => High,
                "low" => Low,
                "original" => Original,
                _ => new ChatContentImageImageUrlDetail(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "high" => true,
            "low" => true,
            "original" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatContentImageImageUrlDetail other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContentImageImageUrlDetail other && Equals(other);
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
        public static bool operator ==(ChatContentImageImageUrlDetail left, ChatContentImageImageUrlDetail right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatContentImageImageUrlDetail left, ChatContentImageImageUrlDetail right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentImageImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentImageImageUrlDetail value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentImageImageUrlDetail? ToEnum(string value)
        {
            return ChatContentImageImageUrlDetail.FromValue(value);
        }
    }
}