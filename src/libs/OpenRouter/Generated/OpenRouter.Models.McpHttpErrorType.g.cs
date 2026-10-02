
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpHttpErrorType
    {
        /// <summary>
        ///
        /// </summary>
        HttpError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpHttpErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpHttpErrorType value)
        {
            return value switch
            {
                McpHttpErrorType.HttpError => "http_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpHttpErrorType? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => McpHttpErrorType.HttpError,
                _ => null,
            };
        }
    }
}