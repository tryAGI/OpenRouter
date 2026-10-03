
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant2Type value)
        {
            return value switch
            {
                ModelOutputV2Variant2Type.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image" => ModelOutputV2Variant2Type.Image,
                _ => null,
            };
        }
    }
}