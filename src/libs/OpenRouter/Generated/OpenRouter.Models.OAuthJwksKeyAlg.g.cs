
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OAuthJwksKeyAlg
    {
        /// <summary>
        ///
        /// </summary>
        Es256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthJwksKeyAlgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthJwksKeyAlg value)
        {
            return value switch
            {
                OAuthJwksKeyAlg.Es256 => "ES256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthJwksKeyAlg? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => OAuthJwksKeyAlg.Es256,
                _ => null,
            };
        }
    }
}