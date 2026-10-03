
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum RequestUnitV2
    {
        /// <summary>
        ///
        /// </summary>
        Request,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestUnitV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestUnitV2 value)
        {
            return value switch
            {
                RequestUnitV2.Request => "request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestUnitV2? ToEnum(string value)
        {
            return value switch
            {
                "request" => RequestUnitV2.Request,
                _ => null,
            };
        }
    }
}