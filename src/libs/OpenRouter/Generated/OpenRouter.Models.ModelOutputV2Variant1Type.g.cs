
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant1Type value)
        {
            return value switch
            {
                ModelOutputV2Variant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ModelOutputV2Variant1Type.Text,
                _ => null,
            };
        }
    }
}