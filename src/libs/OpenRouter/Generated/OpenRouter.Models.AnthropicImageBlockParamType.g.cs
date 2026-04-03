
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicImageBlockParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageBlockParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageBlockParamType value)
        {
            return value switch
            {
                AnthropicImageBlockParamType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageBlockParamType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AnthropicImageBlockParamType.Image,
                _ => null,
            };
        }
    }
}