
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Filter to models with endpoints in the given data region ("eu" or "us").<br/>
    /// Example: eu
    /// </summary>
    public readonly partial struct GetModelsRegion : global::System.IEquatable<GetModelsRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public GetModelsRegion(string value)
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
        public static GetModelsRegion Eu { get; } = new("eu");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static GetModelsRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eu" => Eu,
                "us" => Us,
                _ => new GetModelsRegion(value),
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
        public bool Equals(GetModelsRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetModelsRegion other && Equals(other);
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
        public static bool operator ==(GetModelsRegion left, GetModelsRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetModelsRegion left, GetModelsRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsRegion? ToEnum(string value)
        {
            return GetModelsRegion.FromValue(value);
        }
    }
}