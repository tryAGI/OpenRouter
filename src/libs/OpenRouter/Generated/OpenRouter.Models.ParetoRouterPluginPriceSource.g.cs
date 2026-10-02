
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Price source for the Pareto frontier cost axis and for enforcing max_price. "prompt" uses catalog list price (endpoint.pricing.prompt). "weighted_avg" uses traffic-weighted effective input price from ClickHouse, falling back to prompt price for models without traffic data. Defaults to "prompt".
    /// </summary>
    public readonly partial struct ParetoRouterPluginPriceSource : global::System.IEquatable<ParetoRouterPluginPriceSource>
    {
        /// <summary>
        ///
        /// </summary>
        public ParetoRouterPluginPriceSource(string value)
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
        public static ParetoRouterPluginPriceSource Prompt { get; } = new("prompt");

        /// <summary>
        ///
        /// </summary>
        public static ParetoRouterPluginPriceSource WeightedAvg { get; } = new("weighted_avg");
        /// <summary>
        ///
        /// </summary>
        public static ParetoRouterPluginPriceSource FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "prompt" => Prompt,
                "weighted_avg" => WeightedAvg,
                _ => new ParetoRouterPluginPriceSource(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "prompt" => true,
            "weighted_avg" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ParetoRouterPluginPriceSource other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParetoRouterPluginPriceSource other && Equals(other);
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
        public static bool operator ==(ParetoRouterPluginPriceSource left, ParetoRouterPluginPriceSource right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ParetoRouterPluginPriceSource left, ParetoRouterPluginPriceSource right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParetoRouterPluginPriceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParetoRouterPluginPriceSource value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParetoRouterPluginPriceSource? ToEnum(string value)
        {
            return ParetoRouterPluginPriceSource.FromValue(value);
        }
    }
}