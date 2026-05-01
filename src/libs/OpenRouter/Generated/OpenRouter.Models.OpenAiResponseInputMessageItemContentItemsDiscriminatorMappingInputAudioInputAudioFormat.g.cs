
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat.Mp3 => "mp3",
                OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat.Mp3,
                "wav" => OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}