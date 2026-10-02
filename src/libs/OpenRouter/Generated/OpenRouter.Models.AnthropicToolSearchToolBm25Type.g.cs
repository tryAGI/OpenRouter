
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicToolSearchToolBm25Type : global::System.IEquatable<AnthropicToolSearchToolBm25Type>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicToolSearchToolBm25Type(string value)
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
        public static AnthropicToolSearchToolBm25Type ToolSearchToolBm25 { get; } = new("tool_search_tool_bm25");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchToolBm25Type ToolSearchToolBm2520251119 { get; } = new("tool_search_tool_bm25_20251119");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolSearchToolBm25Type FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "tool_search_tool_bm25" => ToolSearchToolBm25,
                "tool_search_tool_bm25_20251119" => ToolSearchToolBm2520251119,
                _ => new AnthropicToolSearchToolBm25Type(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "tool_search_tool_bm25" => true,
            "tool_search_tool_bm25_20251119" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicToolSearchToolBm25Type other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicToolSearchToolBm25Type other && Equals(other);
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
        public static bool operator ==(AnthropicToolSearchToolBm25Type left, AnthropicToolSearchToolBm25Type right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicToolSearchToolBm25Type left, AnthropicToolSearchToolBm25Type right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchToolBm25TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchToolBm25Type value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchToolBm25Type? ToEnum(string value)
        {
            return AnthropicToolSearchToolBm25Type.FromValue(value);
        }
    }
}