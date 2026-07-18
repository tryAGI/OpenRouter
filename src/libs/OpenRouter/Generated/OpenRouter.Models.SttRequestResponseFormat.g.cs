
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Output format. "json" (default) returns { text, usage }. "verbose_json" additionally returns task, language, duration, and segment-level timestamps; only supported by OpenAI-compatible providers.
    /// </summary>
    public enum SttRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SttRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SttRequestResponseFormat value)
        {
            return value switch
            {
                SttRequestResponseFormat.Json => "json",
                SttRequestResponseFormat.VerboseJson => "verbose_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SttRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => SttRequestResponseFormat.Json,
                "verbose_json" => SttRequestResponseFormat.VerboseJson,
                _ => null,
            };
        }
    }
}