
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChatWebSearchShorthandType : global::System.IEquatable<ChatWebSearchShorthandType>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatWebSearchShorthandType(string value)
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
        public static ChatWebSearchShorthandType WebSearch { get; } = new("web_search");

        /// <summary>
        ///
        /// </summary>
        public static ChatWebSearchShorthandType WebSearch20250826 { get; } = new("web_search_2025_08_26");

        /// <summary>
        ///
        /// </summary>
        public static ChatWebSearchShorthandType WebSearchPreview { get; } = new("web_search_preview");

        /// <summary>
        ///
        /// </summary>
        public static ChatWebSearchShorthandType WebSearchPreview20250311 { get; } = new("web_search_preview_2025_03_11");
        /// <summary>
        ///
        /// </summary>
        public static ChatWebSearchShorthandType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "web_search" => WebSearch,
                "web_search_2025_08_26" => WebSearch20250826,
                "web_search_preview" => WebSearchPreview,
                "web_search_preview_2025_03_11" => WebSearchPreview20250311,
                _ => new ChatWebSearchShorthandType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "web_search" => true,
            "web_search_2025_08_26" => true,
            "web_search_preview" => true,
            "web_search_preview_2025_03_11" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatWebSearchShorthandType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatWebSearchShorthandType other && Equals(other);
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
        public static bool operator ==(ChatWebSearchShorthandType left, ChatWebSearchShorthandType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatWebSearchShorthandType left, ChatWebSearchShorthandType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchShorthandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandType? ToEnum(string value)
        {
            return ChatWebSearchShorthandType.FromValue(value);
        }
    }
}