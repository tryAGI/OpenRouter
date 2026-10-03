
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Only return endpoints in the given data region ("eu" or "us"); a model left without an endpoint is reported as not found. With an API key the record comes from that key's catalog, as on the list route, so a model the key cannot route to is not found.<br/>
    /// Example: eu
    /// </summary>
    public readonly partial struct GetModelV2Region : global::System.IEquatable<GetModelV2Region>
    {
        /// <summary>
        ///
        /// </summary>
        public GetModelV2Region(string value)
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
        public static GetModelV2Region Eu { get; } = new("eu");

        /// <summary>
        ///
        /// </summary>
        public static GetModelV2Region Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static GetModelV2Region FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eu" => Eu,
                "us" => Us,
                _ => new GetModelV2Region(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eu" => true,
            "us" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetModelV2Region other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetModelV2Region other && Equals(other);
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
        public static bool operator ==(GetModelV2Region left, GetModelV2Region right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetModelV2Region left, GetModelV2Region right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelV2RegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelV2Region value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelV2Region? ToEnum(string value)
        {
            return GetModelV2Region.FromValue(value);
        }
    }
}