
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: Bearer
    /// </summary>
    public enum TokenExchangeResponseTokenType
    {
        /// <summary>
        ///
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenExchangeResponseTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenExchangeResponseTokenType value)
        {
            return value switch
            {
                TokenExchangeResponseTokenType.Bearer => "Bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenExchangeResponseTokenType? ToEnum(string value)
        {
            return value switch
            {
                "Bearer" => TokenExchangeResponseTokenType.Bearer,
                _ => null,
            };
        }
    }
}