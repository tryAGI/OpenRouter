
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Must be `urn:ietf:params:oauth:grant-type:token-exchange`.<br/>
    /// Example: urn:ietf:params:oauth:grant-type:token-exchange
    /// </summary>
    public enum TokenExchangeRequestGrantType
    {
        /// <summary>
        /// ietf:params:oauth:grant-type:token-exchange`.
        /// </summary>
        Urn_ietf_params_oauth_grantType_tokenExchange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenExchangeRequestGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenExchangeRequestGrantType value)
        {
            return value switch
            {
                TokenExchangeRequestGrantType.Urn_ietf_params_oauth_grantType_tokenExchange => "urn:ietf:params:oauth:grant-type:token-exchange",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenExchangeRequestGrantType? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:oauth:grant-type:token-exchange" => TokenExchangeRequestGrantType.Urn_ietf_params_oauth_grantType_tokenExchange,
                _ => null,
            };
        }
    }
}