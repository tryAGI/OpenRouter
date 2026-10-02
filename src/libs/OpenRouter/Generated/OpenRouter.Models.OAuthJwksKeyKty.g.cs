
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OAuthJwksKeyKty
    {
        /// <summary>
        ///
        /// </summary>
        Ec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthJwksKeyKtyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthJwksKeyKty value)
        {
            return value switch
            {
                OAuthJwksKeyKty.Ec => "EC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthJwksKeyKty? ToEnum(string value)
        {
            return value switch
            {
                "EC" => OAuthJwksKeyKty.Ec,
                _ => null,
            };
        }
    }
}