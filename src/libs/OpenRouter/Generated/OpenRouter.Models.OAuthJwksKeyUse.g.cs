
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OAuthJwksKeyUse
    {
        /// <summary>
        ///
        /// </summary>
        Sig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthJwksKeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthJwksKeyUse value)
        {
            return value switch
            {
                OAuthJwksKeyUse.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthJwksKeyUse? ToEnum(string value)
        {
            return value switch
            {
                "sig" => OAuthJwksKeyUse.Sig,
                _ => null,
            };
        }
    }
}