
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InputPricingEntryV2Variant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputPricingEntryV2Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputPricingEntryV2Variant1Type value)
        {
            return value switch
            {
                InputPricingEntryV2Variant1Type.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputPricingEntryV2Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => InputPricingEntryV2Variant1Type.Prompt,
                _ => null,
            };
        }
    }
}