
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: direct
    /// </summary>
    public readonly partial struct RoutingStrategy : global::System.IEquatable<RoutingStrategy>
    {
        /// <summary>
        ///
        /// </summary>
        public RoutingStrategy(string value)
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
        public static RoutingStrategy Alias { get; } = new("alias");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Bodybuilder { get; } = new("bodybuilder");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Direct { get; } = new("direct");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Fallback { get; } = new("fallback");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Free { get; } = new("free");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Fusion { get; } = new("fusion");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Latest { get; } = new("latest");

        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy Pareto { get; } = new("pareto");
        /// <summary>
        ///
        /// </summary>
        public static RoutingStrategy FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "alias" => Alias,
                "auto" => Auto,
                "bodybuilder" => Bodybuilder,
                "direct" => Direct,
                "fallback" => Fallback,
                "free" => Free,
                "fusion" => Fusion,
                "latest" => Latest,
                "pareto" => Pareto,
                _ => new RoutingStrategy(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "alias" => true,
            "auto" => true,
            "bodybuilder" => true,
            "direct" => true,
            "fallback" => true,
            "free" => true,
            "fusion" => true,
            "latest" => true,
            "pareto" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(RoutingStrategy other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RoutingStrategy other && Equals(other);
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
        public static bool operator ==(RoutingStrategy left, RoutingStrategy right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RoutingStrategy left, RoutingStrategy right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoutingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingStrategy value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingStrategy? ToEnum(string value)
        {
            return RoutingStrategy.FromValue(value);
        }
    }
}