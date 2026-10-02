
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Must be `urn:ietf:params:oauth:token-type:jwt`.<br/>
    /// Example: urn:ietf:params:oauth:token-type:jwt
    /// </summary>
    public enum TokenExchangeRequestSubjectTokenType
    {
        /// <summary>
        /// ietf:params:oauth:token-type:jwt`.
        /// </summary>
        Urn_ietf_params_oauth_tokenType_jwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenExchangeRequestSubjectTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenExchangeRequestSubjectTokenType value)
        {
            return value switch
            {
                TokenExchangeRequestSubjectTokenType.Urn_ietf_params_oauth_tokenType_jwt => "urn:ietf:params:oauth:token-type:jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenExchangeRequestSubjectTokenType? ToEnum(string value)
        {
            return value switch
            {
                "urn:ietf:params:oauth:token-type:jwt" => TokenExchangeRequestSubjectTokenType.Urn_ietf_params_oauth_tokenType_jwt,
                _ => null,
            };
        }
    }
}