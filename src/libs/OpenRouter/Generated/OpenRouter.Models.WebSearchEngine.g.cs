
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The search engine to use for web search.<br/>
    /// Example: exa
    /// </summary>
    public readonly partial struct WebSearchEngine : global::System.IEquatable<WebSearchEngine>
    {
        /// <summary>
        ///
        /// </summary>
        public WebSearchEngine(string value)
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
        public static WebSearchEngine Exa { get; } = new("exa");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngine Firecrawl { get; } = new("firecrawl");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngine Native { get; } = new("native");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngine Parallel { get; } = new("parallel");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngine Perplexity { get; } = new("perplexity");
        /// <summary>
        ///
        /// </summary>
        public static WebSearchEngine FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "exa" => Exa,
                "firecrawl" => Firecrawl,
                "native" => Native,
                "parallel" => Parallel,
                "perplexity" => Perplexity,
                _ => new WebSearchEngine(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
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
        public bool Equals(WebSearchEngine other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchEngine other && Equals(other);
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
        public static bool operator ==(WebSearchEngine left, WebSearchEngine right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchEngine left, WebSearchEngine right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchEngine value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchEngine? ToEnum(string value)
        {
            return WebSearchEngine.FromValue(value);
        }
    }
}