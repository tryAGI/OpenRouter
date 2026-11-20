
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// `excluded`: `voice` is rejected when the request also sends a nonempty `input_references`. Absent: they can be combined.
    /// </summary>
    public enum SpeechVoiceParameterReferences
    {
        /// <summary>
        /// `voice` is rejected when the request also sends a nonempty `input_references`. Absent: they can be combined.
        /// </summary>
        Excluded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechVoiceParameterReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechVoiceParameterReferences value)
        {
            return value switch
            {
                SpeechVoiceParameterReferences.Excluded => "excluded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechVoiceParameterReferences? ToEnum(string value)
        {
            return value switch
            {
                "excluded" => SpeechVoiceParameterReferences.Excluded,
                _ => null,
            };
        }
    }
}