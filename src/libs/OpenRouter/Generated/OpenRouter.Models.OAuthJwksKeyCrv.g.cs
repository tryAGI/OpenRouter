
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OAuthJwksKeyCrv
    {
        /// <summary>
        ///
        /// </summary>
        P256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthJwksKeyCrvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthJwksKeyCrv value)
        {
            return value switch
            {
                OAuthJwksKeyCrv.P256 => "P-256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthJwksKeyCrv? ToEnum(string value)
        {
            return value switch
            {
                "P-256" => OAuthJwksKeyCrv.P256,
                _ => null,
            };
        }
    }
}