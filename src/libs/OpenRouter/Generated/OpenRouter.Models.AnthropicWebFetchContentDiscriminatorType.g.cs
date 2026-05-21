
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebFetchContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchResult,
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchContentDiscriminatorType value)
        {
            return value switch
            {
                AnthropicWebFetchContentDiscriminatorType.WebFetchResult => "web_fetch_result",
                AnthropicWebFetchContentDiscriminatorType.WebFetchToolResultError => "web_fetch_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_result" => AnthropicWebFetchContentDiscriminatorType.WebFetchResult,
                "web_fetch_tool_result_error" => AnthropicWebFetchContentDiscriminatorType.WebFetchToolResultError,
                _ => null,
            };
        }
    }
}