
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: urn:ietf:params:oauth:token-type:access_token
    /// </summary>
    public enum TokenExchangeResponseIssuedTokenType
    {
        /// <summary>
        ///
        /// </summary>
        Urn_ietf_params_oauth_tokenType_accessToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenExchangeResponseIssuedTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenExchangeResponseIssuedTokenType value)
        {
            return value switch
            {
                TokenExchangeResponseIssuedTokenType.Urn_ietf_params_oauth_tokenType_accessToken => "urn:ietf:params:oauth:token-type:access_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenExchangeResponseIssuedTokenType? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:oauth:token-type:access_token" => TokenExchangeResponseIssuedTokenType.Urn_ietf_params_oauth_tokenType_accessToken,
                _ => null,
            };
        }
    }
}