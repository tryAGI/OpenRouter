
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImagePricingEntryUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Megapixel,
        /// <summary>
        /// 
        /// </summary>
        Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImagePricingEntryUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagePricingEntryUnit value)
        {
            return value switch
            {
                ImagePricingEntryUnit.Image => "image",
                ImagePricingEntryUnit.Megapixel => "megapixel",
                ImagePricingEntryUnit.Token => "token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagePricingEntryUnit? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImagePricingEntryUnit.Image,
                "megapixel" => ImagePricingEntryUnit.Megapixel,
                "token" => ImagePricingEntryUnit.Token,
                _ => null,
            };
        }
    }
}