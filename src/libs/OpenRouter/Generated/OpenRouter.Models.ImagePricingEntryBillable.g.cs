
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImagePricingEntryBillable
    {
        /// <summary>
        /// 
        /// </summary>
        InputFont,
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        InputReference,
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        OutputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImagePricingEntryBillableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagePricingEntryBillable value)
        {
            return value switch
            {
                ImagePricingEntryBillable.InputFont => "input_font",
                ImagePricingEntryBillable.InputImage => "input_image",
                ImagePricingEntryBillable.InputReference => "input_reference",
                ImagePricingEntryBillable.InputText => "input_text",
                ImagePricingEntryBillable.OutputImage => "output_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagePricingEntryBillable? ToEnum(string value)
        {
            return value switch
            {
                "input_font" => ImagePricingEntryBillable.InputFont,
                "input_image" => ImagePricingEntryBillable.InputImage,
                "input_reference" => ImagePricingEntryBillable.InputReference,
                "input_text" => ImagePricingEntryBillable.InputText,
                "output_image" => ImagePricingEntryBillable.OutputImage,
                _ => null,
            };
        }
    }
}