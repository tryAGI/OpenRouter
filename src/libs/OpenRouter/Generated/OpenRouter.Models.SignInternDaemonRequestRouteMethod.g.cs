
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The HTTP method of the daemon request.
    /// </summary>
    public enum SignInternDaemonRequestRouteMethod
    {
        /// <summary>
        ///
        /// </summary>
        Post,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SignInternDaemonRequestRouteMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignInternDaemonRequestRouteMethod value)
        {
            return value switch
            {
                SignInternDaemonRequestRouteMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignInternDaemonRequestRouteMethod? ToEnum(string value)
        {
            return value switch
            {
                "POST" => SignInternDaemonRequestRouteMethod.Post,
                _ => null,
            };
        }
    }
}