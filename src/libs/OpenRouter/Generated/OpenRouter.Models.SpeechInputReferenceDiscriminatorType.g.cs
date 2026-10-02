
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechInputReferenceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
        /// <summary>
        ///
        /// </summary>
        InputAudio,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputReferenceDiscriminatorType value)
        {
            return value switch
            {
                SpeechInputReferenceDiscriminatorType.ImageUrl => "image_url",
                SpeechInputReferenceDiscriminatorType.InputAudio => "input_audio",
                SpeechInputReferenceDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => SpeechInputReferenceDiscriminatorType.ImageUrl,
                "input_audio" => SpeechInputReferenceDiscriminatorType.InputAudio,
                "text" => SpeechInputReferenceDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}