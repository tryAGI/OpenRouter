
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// **DEPRECATED** Use providers.sort.partition instead. Backwards-compatible alias for providers.sort.partition. Accepts legacy values: "fallback" (maps to "model"), "sort" (maps to "none").<br/>
    /// Example: fallback
    /// </summary>
    public readonly partial struct DeprecatedRoute : global::System.IEquatable<DeprecatedRoute>
    {
        /// <summary>
        ///
        /// </summary>
        public DeprecatedRoute(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// "fallback" (maps to "model"), "sort" (maps to "none").
        /// </summary>
        public static DeprecatedRoute Fallback { get; } = new("fallback");

        /// <summary>
        /// "fallback" (maps to "model"), "sort" (maps to "none").
        /// </summary>
        public static DeprecatedRoute Sort { get; } = new("sort");
        /// <summary>
        ///
        /// </summary>
        public static DeprecatedRoute FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "fallback" => Fallback,
                "sort" => Sort,
                _ => new DeprecatedRoute(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "fallback" => true,
            "sort" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DeprecatedRoute other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeprecatedRoute other && Equals(other);
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
        public static bool operator ==(DeprecatedRoute left, DeprecatedRoute right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeprecatedRoute left, DeprecatedRoute right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeprecatedRouteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeprecatedRoute value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeprecatedRoute? ToEnum(string value)
        {
            return DeprecatedRoute.FromValue(value);
        }
    }
}