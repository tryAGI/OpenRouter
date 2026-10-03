
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant9Type
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant9Type value)
        {
            return value switch
            {
                ModelOutputV2Variant9Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant9Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ModelOutputV2Variant9Type.Audio,
                _ => null,
            };
        }
    }
}