
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: web_fetch_result
    /// </summary>
    public enum AnthropicWebFetchContentVariant1Type
    {
        /// <summary>
        /// web_fetch_result
        /// </summary>
        WebFetchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchContentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchContentVariant1Type value)
        {
            return value switch
            {
                AnthropicWebFetchContentVariant1Type.WebFetchResult => "web_fetch_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchContentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_result" => AnthropicWebFetchContentVariant1Type.WebFetchResult,
                _ => null,
            };
        }
    }
}