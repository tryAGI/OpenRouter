
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseInputMessageItemRole1
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemRole1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemRole1 value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemRole1.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemRole1? ToEnum(string value)
        {
            return value switch
            {
                "system" => OpenAiResponseInputMessageItemRole1.System,
                _ => null,
            };
        }
    }
}