
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Engine-native search mode. Exa supports instant, fast, auto (default), deep-lite, deep, and deep-reasoning. Parallel supports turbo, fast, basic (default), and advanced. Modes unsupported by the selected engine are ignored.<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct WebSearchMode : global::System.IEquatable<WebSearchMode>
    {
        /// <summary>
        ///
        /// </summary>
        public WebSearchMode(string value)
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
        public static WebSearchMode Advanced { get; } = new("advanced");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode Basic { get; } = new("basic");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode Deep { get; } = new("deep");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode DeepLite { get; } = new("deep-lite");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode DeepReasoning { get; } = new("deep-reasoning");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode Fast { get; } = new("fast");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode Instant { get; } = new("instant");

        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode Turbo { get; } = new("turbo");
        /// <summary>
        ///
        /// </summary>
        public static WebSearchMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "advanced" => Advanced,
                "auto" => Auto,
                "basic" => Basic,
                "deep" => Deep,
                "deep-lite" => DeepLite,
                "deep-reasoning" => DeepReasoning,
                "fast" => Fast,
                "instant" => Instant,
                "turbo" => Turbo,
                _ => new WebSearchMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "advanced" => true,
            "auto" => true,
            "basic" => true,
            "deep" => true,
            "deep-lite" => true,
            "deep-reasoning" => true,
            "fast" => true,
            "instant" => true,
            "turbo" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WebSearchMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchMode other && Equals(other);
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
        public static bool operator ==(WebSearchMode left, WebSearchMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchMode left, WebSearchMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchMode? ToEnum(string value)
        {
            return WebSearchMode.FromValue(value);
        }
    }
}