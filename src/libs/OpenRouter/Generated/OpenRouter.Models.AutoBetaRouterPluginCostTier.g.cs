
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Named cost/quality setting. For auto-beta-router, tiers select cost-percentile bands: low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.<br/>
    /// Example: low
    /// </summary>
    public readonly partial struct AutoBetaRouterPluginCostTier : global::System.IEquatable<AutoBetaRouterPluginCostTier>
    {
        /// <summary>
        ///
        /// </summary>
        public AutoBetaRouterPluginCostTier(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.
        /// </summary>
        public static AutoBetaRouterPluginCostTier High { get; } = new("high");

        /// <summary>
        /// low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.
        /// </summary>
        public static AutoBetaRouterPluginCostTier Low { get; } = new("low");

        /// <summary>
        /// low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.
        /// </summary>
        public static AutoBetaRouterPluginCostTier Max { get; } = new("max");

        /// <summary>
        /// low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.
        /// </summary>
        public static AutoBetaRouterPluginCostTier Medium { get; } = new("medium");

        /// <summary>
        /// low = [0, 20), medium = [20, 40), high = [40, 60), xhigh = [60, 80), and max = [80, 100]. Takes precedence over the deprecated numeric cost_quality_tradeoff when both are provided.
        /// </summary>
        public static AutoBetaRouterPluginCostTier Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static AutoBetaRouterPluginCostTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "xhigh" => Xhigh,
                _ => new AutoBetaRouterPluginCostTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "high" => true,
            "low" => true,
            "max" => true,
            "medium" => true,
            "xhigh" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoBetaRouterPluginCostTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoBetaRouterPluginCostTier other && Equals(other);
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
        public static bool operator ==(AutoBetaRouterPluginCostTier left, AutoBetaRouterPluginCostTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoBetaRouterPluginCostTier left, AutoBetaRouterPluginCostTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoBetaRouterPluginCostTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoBetaRouterPluginCostTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoBetaRouterPluginCostTier? ToEnum(string value)
        {
            return AutoBetaRouterPluginCostTier.FromValue(value);
        }
    }
}