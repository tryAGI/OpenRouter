
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A timestamp detail level for verbose_json transcription responses.
    /// </summary>
    public enum STTTimestampGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTTimestampGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTTimestampGranularity value)
        {
            return value switch
            {
                STTTimestampGranularity.Segment => "segment",
                STTTimestampGranularity.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTTimestampGranularity? ToEnum(string value)
        {
            return value switch
            {
                "segment" => STTTimestampGranularity.Segment,
                "word" => STTTimestampGranularity.Word,
                _ => null,
            };
        }
    }
}