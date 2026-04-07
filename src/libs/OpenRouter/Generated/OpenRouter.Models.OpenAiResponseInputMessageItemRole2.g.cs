
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseInputMessageItemRole2
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemRole2 value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemRole2.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemRole2? ToEnum(string value)
        {
            return value switch
            {
                "developer" => OpenAiResponseInputMessageItemRole2.Developer,
                _ => null,
            };
        }
    }
}