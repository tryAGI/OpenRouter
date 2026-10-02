
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Configuration for a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool. A curated OpenRouter preset (slugs follow `&lt;task&gt;-&lt;tier&gt;`, e.g. `general-high`). Expands server-side into the preset's analysis_models panel and analyst model, so callers never name individual models. Explicitly provided `analysis_models` / `model` take precedence.<br/>
    /// Example: general-high
    /// </summary>
    public readonly partial struct FusionPluginPreset : global::System.IEquatable<FusionPluginPreset>
    {
        /// <summary>
        ///
        /// </summary>
        public FusionPluginPreset(string value)
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
        public static FusionPluginPreset GeneralBudget { get; } = new("general-budget");

        /// <summary>
        ///
        /// </summary>
        public static FusionPluginPreset GeneralFast { get; } = new("general-fast");

        /// <summary>
        /// fusion` server tool. A curated OpenRouter preset (slugs follow `&lt;task&gt;-&lt;tier&gt;`, e.g. `general-high`). Expands server-side into the preset's analysis_models panel and analyst model, so callers never name individual models. Explicitly provided `analysis_models` / `model` take precedence.
        /// </summary>
        public static FusionPluginPreset GeneralHigh { get; } = new("general-high");
        /// <summary>
        ///
        /// </summary>
        public static FusionPluginPreset FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "general-budget" => GeneralBudget,
                "general-fast" => GeneralFast,
                "general-high" => GeneralHigh,
                _ => new FusionPluginPreset(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "general-budget" => true,
            "general-fast" => true,
            "general-high" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(FusionPluginPreset other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FusionPluginPreset other && Equals(other);
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
        public static bool operator ==(FusionPluginPreset left, FusionPluginPreset right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FusionPluginPreset left, FusionPluginPreset right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionPluginPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionPluginPreset value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionPluginPreset? ToEnum(string value)
        {
            return FusionPluginPreset.FromValue(value);
        }
    }
}