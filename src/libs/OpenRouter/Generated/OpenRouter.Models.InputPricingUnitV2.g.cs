
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `megapixel` prices resolution-scaled media: `cost_usd` is the rate per megapixel (1,000,000 pixels) of media area, so cost scales linearly with the pixel dimensions of the input consumed or output generated.
    /// </summary>
    public readonly partial struct InputPricingUnitV2 : global::System.IEquatable<InputPricingUnitV2>
    {
        /// <summary>
        ///
        /// </summary>
        public InputPricingUnitV2(string value)
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
        public static InputPricingUnitV2 Character { get; } = new("character");

        /// <summary>
        ///
        /// </summary>
        public static InputPricingUnitV2 Image { get; } = new("image");

        /// <summary>
        /// `cost_usd` is the rate per megapixel (1,000,000 pixels) of media area, so cost scales linearly with the pixel dimensions of the input consumed or output generated.
        /// </summary>
        public static InputPricingUnitV2 Megapixel { get; } = new("megapixel");

        /// <summary>
        ///
        /// </summary>
        public static InputPricingUnitV2 Second { get; } = new("second");

        /// <summary>
        ///
        /// </summary>
        public static InputPricingUnitV2 Token { get; } = new("token");
        /// <summary>
        ///
        /// </summary>
        public static InputPricingUnitV2 FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "character" => Character,
                "image" => Image,
                "megapixel" => Megapixel,
                "second" => Second,
                "token" => Token,
                _ => new InputPricingUnitV2(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "character" => true,
            "image" => true,
            "megapixel" => true,
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
        public bool Equals(InputPricingUnitV2 other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputPricingUnitV2 other && Equals(other);
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
        public static bool operator ==(InputPricingUnitV2 left, InputPricingUnitV2 right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputPricingUnitV2 left, InputPricingUnitV2 right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputPricingUnitV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputPricingUnitV2 value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputPricingUnitV2? ToEnum(string value)
        {
            return InputPricingUnitV2.FromValue(value);
        }
    }
}