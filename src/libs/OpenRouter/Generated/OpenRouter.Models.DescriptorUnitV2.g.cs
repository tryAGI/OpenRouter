
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DescriptorUnitV2 : global::System.IEquatable<DescriptorUnitV2>
    {
        /// <summary>
        ///
        /// </summary>
        public DescriptorUnitV2(string value)
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
        public static DescriptorUnitV2 Byte { get; } = new("byte");

        /// <summary>
        ///
        /// </summary>
        public static DescriptorUnitV2 Character { get; } = new("character");

        /// <summary>
        ///
        /// </summary>
        public static DescriptorUnitV2 Pixel { get; } = new("pixel");

        /// <summary>
        ///
        /// </summary>
        public static DescriptorUnitV2 Second { get; } = new("second");

        /// <summary>
        ///
        /// </summary>
        public static DescriptorUnitV2 Token { get; } = new("token");
        /// <summary>
        ///
        /// </summary>
        public static DescriptorUnitV2 FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "byte" => Byte,
                "character" => Character,
                "pixel" => Pixel,
                "second" => Second,
                "token" => Token,
                _ => new DescriptorUnitV2(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "byte" => true,
            "character" => true,
            "pixel" => true,
            "second" => true,
            "token" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DescriptorUnitV2 other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DescriptorUnitV2 other && Equals(other);
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
        public static bool operator ==(DescriptorUnitV2 left, DescriptorUnitV2 right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DescriptorUnitV2 left, DescriptorUnitV2 right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DescriptorUnitV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DescriptorUnitV2 value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DescriptorUnitV2? ToEnum(string value)
        {
            return DescriptorUnitV2.FromValue(value);
        }
    }
}