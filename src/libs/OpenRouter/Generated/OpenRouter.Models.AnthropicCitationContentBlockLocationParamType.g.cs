
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationContentBlockLocationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationContentBlockLocationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationContentBlockLocationParamType value)
        {
            return value switch
            {
                AnthropicCitationContentBlockLocationParamType.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationContentBlockLocationParamType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => AnthropicCitationContentBlockLocationParamType.ContentBlockLocation,
                _ => null,
            };
        }
    }
}