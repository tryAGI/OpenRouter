
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: audio_url
    /// </summary>
    public enum InputReferenceVariant1Type
    {
        /// <summary>
        /// audio_url
        /// </summary>
        AudioUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputReferenceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputReferenceVariant1Type value)
        {
            return value switch
            {
                InputReferenceVariant1Type.AudioUrl => "audio_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputReferenceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => InputReferenceVariant1Type.AudioUrl,
                _ => null,
            };
        }
    }
}