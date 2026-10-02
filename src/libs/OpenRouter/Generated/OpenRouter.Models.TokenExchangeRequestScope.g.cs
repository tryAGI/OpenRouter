
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Optional; only `inference` is available.<br/>
    /// Example: inference
    /// </summary>
    public enum TokenExchangeRequestScope
    {
        /// <summary>
        ///
        /// </summary>
        Inference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenExchangeRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenExchangeRequestScope value)
        {
            return value switch
            {
                TokenExchangeRequestScope.Inference => "inference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenExchangeRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "inference" => TokenExchangeRequestScope.Inference,
                _ => null,
            };
        }
    }
}