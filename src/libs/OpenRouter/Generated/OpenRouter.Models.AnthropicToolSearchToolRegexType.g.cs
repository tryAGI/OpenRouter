
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicToolSearchToolRegexType : global::System.IEquatable<AnthropicToolSearchToolRegexType>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchToolRegexType(string value)
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
        public static AnthropicToolSearchToolRegexType ToolSearchToolRegex { get; } = new("tool_search_tool_regex");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchToolRegexType ToolSearchToolRegex20251119 { get; } = new("tool_search_tool_regex_20251119");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchToolRegexType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "tool_search_tool_regex" => ToolSearchToolRegex,
                "tool_search_tool_regex_20251119" => ToolSearchToolRegex20251119,
                _ => new AnthropicToolSearchToolRegexType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "tool_search_tool_regex" => true,
            "tool_search_tool_regex_20251119" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicToolSearchToolRegexType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicToolSearchToolRegexType other && Equals(other);
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
        public static bool operator ==(AnthropicToolSearchToolRegexType left, AnthropicToolSearchToolRegexType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicToolSearchToolRegexType left, AnthropicToolSearchToolRegexType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchToolRegexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchToolRegexType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchToolRegexType? ToEnum(string value)
        {
            return AnthropicToolSearchToolRegexType.FromValue(value);
        }
    }
}