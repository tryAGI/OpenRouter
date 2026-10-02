
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Size of the search context for web search tools<br/>
    /// Example: medium
    /// </summary>
    public readonly partial struct SearchContextSizeEnum : global::System.IEquatable<SearchContextSizeEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public SearchContextSizeEnum(string value)
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
        public static SearchContextSizeEnum High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static SearchContextSizeEnum Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static SearchContextSizeEnum Medium { get; } = new("medium");
        /// <summary>
        ///
        /// </summary>
        public static SearchContextSizeEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "medium" => Medium,
                _ => new SearchContextSizeEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "high" => true,
            "low" => true,
            "medium" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SearchContextSizeEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchContextSizeEnum other && Equals(other);
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
        public static bool operator ==(SearchContextSizeEnum left, SearchContextSizeEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchContextSizeEnum left, SearchContextSizeEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchContextSizeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchContextSizeEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchContextSizeEnum? ToEnum(string value)
        {
            return SearchContextSizeEnum.FromValue(value);
        }
    }
}