
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Optional; when present must be `urn:ietf:params:oauth:token-type:access_token`.<br/>
    /// Example: urn:ietf:params:oauth:token-type:access_token
    /// </summary>
    public enum TokenExchangeRequestRequestedTokenType
    {
        /// <summary>
        /// ietf:params:oauth:token-type:access_token`.
        /// </summary>
        Urn_ietf_params_oauth_tokenType_accessToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenExchangeRequestRequestedTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenExchangeRequestRequestedTokenType value)
        {
            return value switch
            {
                TokenExchangeRequestRequestedTokenType.Urn_ietf_params_oauth_tokenType_accessToken => "urn:ietf:params:oauth:token-type:access_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenExchangeRequestRequestedTokenType? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:oauth:token-type:access_token" => TokenExchangeRequestRequestedTokenType.Urn_ietf_params_oauth_tokenType_accessToken,
                _ => null,
            };
        }
    }
}