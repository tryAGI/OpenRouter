
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Who bills the engine's calls beyond the model's tokens: `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)<br/>
    /// Example: openrouter
    /// </summary>
    public readonly partial struct ServerToolEnginePricingSource : global::System.IEquatable<ServerToolEnginePricingSource>
    {
        /// <summary>
        ///
        /// </summary>
        public ServerToolEnginePricingSource(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)
        /// </summary>
        public static ServerToolEnginePricingSource Byok { get; } = new("byok");

        /// <summary>
        /// `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)
        /// </summary>
        public static ServerToolEnginePricingSource None { get; } = new("none");

        /// <summary>
        /// `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)
        /// </summary>
        public static ServerToolEnginePricingSource Openrouter { get; } = new("openrouter");

        /// <summary>
        /// `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)
        /// </summary>
        public static ServerToolEnginePricingSource Provider { get; } = new("provider");
        /// <summary>
        ///
        /// </summary>
        public static ServerToolEnginePricingSource FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "byok" => Byok,
                "none" => None,
                "openrouter" => Openrouter,
                "provider" => Provider,
                _ => new ServerToolEnginePricingSource(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "byok" => true,
            "none" => true,
            "openrouter" => true,
            "provider" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerToolEnginePricingSource other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolEnginePricingSource other && Equals(other);
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
        public static bool operator ==(ServerToolEnginePricingSource left, ServerToolEnginePricingSource right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolEnginePricingSource left, ServerToolEnginePricingSource right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolEnginePricingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolEnginePricingSource value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolEnginePricingSource? ToEnum(string value)
        {
            return ServerToolEnginePricingSource.FromValue(value);
        }
    }
}