
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which fetch engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in fetch. "exa" uses Exa Contents API. "openrouter" uses direct HTTP fetch. "firecrawl" uses Firecrawl scrape (requires BYOK). "parallel" uses the Parallel extract API.<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct WebFetchEngineEnum : global::System.IEquatable<WebFetchEngineEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public WebFetchEngineEnum(string value)
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
        public static WebFetchEngineEnum Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static WebFetchEngineEnum Exa { get; } = new("exa");

        /// <summary>
        ///
        /// </summary>
        public static WebFetchEngineEnum Firecrawl { get; } = new("firecrawl");

        /// <summary>
        ///
        /// </summary>
        public static WebFetchEngineEnum Native { get; } = new("native");

        /// <summary>
        ///
        /// </summary>
        public static WebFetchEngineEnum Openrouter { get; } = new("openrouter");

        /// <summary>
        ///
        /// </summary>
        public static WebFetchEngineEnum Parallel { get; } = new("parallel");
        /// <summary>
        ///
        /// </summary>
        public static WebFetchEngineEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "exa" => Exa,
                "firecrawl" => Firecrawl,
                "native" => Native,
                "openrouter" => Openrouter,
                "parallel" => Parallel,
                _ => new WebFetchEngineEnum(value),
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
            "openrouter" => true,
            "parallel" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WebFetchEngineEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebFetchEngineEnum other && Equals(other);
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
        public static bool operator ==(WebFetchEngineEnum left, WebFetchEngineEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebFetchEngineEnum left, WebFetchEngineEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchEngineEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchEngineEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchEngineEnum? ToEnum(string value)
        {
            return WebFetchEngineEnum.FromValue(value);
        }
    }
}