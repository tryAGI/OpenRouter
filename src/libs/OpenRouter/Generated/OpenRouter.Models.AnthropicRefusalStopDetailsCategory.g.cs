
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicRefusalStopDetailsCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Bio,
        /// <summary>
        /// 
        /// </summary>
        Cyber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicRefusalStopDetailsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicRefusalStopDetailsCategory value)
        {
            return value switch
            {
                AnthropicRefusalStopDetailsCategory.Bio => "bio",
                AnthropicRefusalStopDetailsCategory.Cyber => "cyber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory? ToEnum(string value)
        {
            return value switch
            {
                "bio" => AnthropicRefusalStopDetailsCategory.Bio,
                "cyber" => AnthropicRefusalStopDetailsCategory.Cyber,
                _ => null,
            };
        }
    }
}