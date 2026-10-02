
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The data region this generation was routed through: 'global', 'europe', or 'us'.<br/>
    /// Example: global
    /// </summary>
    public readonly partial struct GenerationResponseDataDataRegion : global::System.IEquatable<GenerationResponseDataDataRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public GenerationResponseDataDataRegion(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// 'global', 'europe', or 'us'.
        /// </summary>
        public static GenerationResponseDataDataRegion Europe { get; } = new("europe");

        /// <summary>
        /// 'global', 'europe', or 'us'.
        /// </summary>
        public static GenerationResponseDataDataRegion Global { get; } = new("global");

        /// <summary>
        /// 'global', 'europe', or 'us'.
        /// </summary>
        public static GenerationResponseDataDataRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static GenerationResponseDataDataRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new GenerationResponseDataDataRegion(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "europe" => true,
            "global" => true,
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
        public bool Equals(GenerationResponseDataDataRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerationResponseDataDataRegion other && Equals(other);
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
        public static bool operator ==(GenerationResponseDataDataRegion left, GenerationResponseDataDataRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GenerationResponseDataDataRegion left, GenerationResponseDataDataRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataDataRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataDataRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataDataRegion? ToEnum(string value)
        {
            return GenerationResponseDataDataRegion.FromValue(value);
        }
    }
}