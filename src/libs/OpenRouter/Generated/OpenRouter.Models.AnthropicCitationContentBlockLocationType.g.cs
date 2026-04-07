
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationContentBlockLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationContentBlockLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationContentBlockLocationType value)
        {
            return value switch
            {
                AnthropicCitationContentBlockLocationType.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationContentBlockLocationType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => AnthropicCitationContentBlockLocationType.ContentBlockLocation,
                _ => null,
            };
        }
    }
}