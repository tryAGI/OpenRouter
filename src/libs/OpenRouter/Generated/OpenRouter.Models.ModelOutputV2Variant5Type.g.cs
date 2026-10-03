
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant5Type
    {
        /// <summary>
        ///
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant5Type value)
        {
            return value switch
            {
                ModelOutputV2Variant5Type.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant5Type? ToEnum(string value)
        {
            return value switch
            {
                "transcription" => ModelOutputV2Variant5Type.Transcription,
                _ => null,
            };
        }
    }
}