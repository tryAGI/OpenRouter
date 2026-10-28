
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionsImageAssetFormat : global::System.IEquatable<DecisionsImageAssetFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public DecisionsImageAssetFormat(string value)
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
        public static DecisionsImageAssetFormat Jpeg { get; } = new("jpeg");

        /// <summary>
        ///
        /// </summary>
        public static DecisionsImageAssetFormat Jpg { get; } = new("jpg");

        /// <summary>
        ///
        /// </summary>
        public static DecisionsImageAssetFormat Png { get; } = new("png");
        /// <summary>
        ///
        /// </summary>
        public static DecisionsImageAssetFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "jpeg" => Jpeg,
                "jpg" => Jpg,
                "png" => Png,
                _ => new DecisionsImageAssetFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "jpeg" => true,
            "jpg" => true,
            "png" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DecisionsImageAssetFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionsImageAssetFormat other && Equals(other);
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
        public static bool operator ==(DecisionsImageAssetFormat left, DecisionsImageAssetFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionsImageAssetFormat left, DecisionsImageAssetFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsImageAssetFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsImageAssetFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsImageAssetFormat? ToEnum(string value)
        {
            return DecisionsImageAssetFormat.FromValue(value);
        }
    }
}