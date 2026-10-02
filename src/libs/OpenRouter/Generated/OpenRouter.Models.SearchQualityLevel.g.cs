
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How much context to retrieve per result. Applies to Exa, Parallel, and Perplexity engines; ignored with native provider search and Firecrawl. For Exa, pins a fixed per-result character cap (low=5,000, medium=15,000, high=30,000); when omitted, Exa picks an adaptive size per query and document (typically ~2,000–4,000 characters per result). For Parallel, controls the total characters across all results; when omitted, Parallel uses its own default size. For Perplexity, maps directly to the Search API's native search_context_size parameter. Overridden by `max_characters` when both are set.<br/>
    /// Example: medium
    /// </summary>
    public readonly partial struct SearchQualityLevel : global::System.IEquatable<SearchQualityLevel>
    {
        /// <summary>
        ///
        /// </summary>
        public SearchQualityLevel(string value)
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
        public static SearchQualityLevel High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static SearchQualityLevel Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static SearchQualityLevel Medium { get; } = new("medium");
        /// <summary>
        ///
        /// </summary>
        public static SearchQualityLevel FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "medium" => Medium,
                _ => new SearchQualityLevel(value),
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
        public bool Equals(SearchQualityLevel other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchQualityLevel other && Equals(other);
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
        public static bool operator ==(SearchQualityLevel left, SearchQualityLevel right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchQualityLevel left, SearchQualityLevel right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchQualityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchQualityLevel value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchQualityLevel? ToEnum(string value)
        {
            return SearchQualityLevel.FromValue(value);
        }
    }
}