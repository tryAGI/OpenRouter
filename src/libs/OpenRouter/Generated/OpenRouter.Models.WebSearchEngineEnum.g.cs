
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API. "perplexity" uses the Perplexity Search API (raw ranked results).<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct WebSearchEngineEnum : global::System.IEquatable<WebSearchEngineEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public WebSearchEngineEnum(string value)
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
        public static WebSearchEngineEnum Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngineEnum Exa { get; } = new("exa");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngineEnum Firecrawl { get; } = new("firecrawl");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngineEnum Native { get; } = new("native");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngineEnum Parallel { get; } = new("parallel");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngineEnum Perplexity { get; } = new("perplexity");
        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngineEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "exa" => Exa,
                "firecrawl" => Firecrawl,
                "native" => Native,
                "parallel" => Parallel,
                "perplexity" => Perplexity,
                _ => new WebSearchEngineEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "exa" => true,
            "firecrawl" => true,
            "native" => true,
            "parallel" => true,
            "perplexity" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WebSearchEngineEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchEngineEnum other && Equals(other);
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
        public static bool operator ==(WebSearchEngineEnum left, WebSearchEngineEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchEngineEnum left, WebSearchEngineEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchEngineEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchEngineEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchEngineEnum? ToEnum(string value)
        {
            return WebSearchEngineEnum.FromValue(value);
        }
    }
}