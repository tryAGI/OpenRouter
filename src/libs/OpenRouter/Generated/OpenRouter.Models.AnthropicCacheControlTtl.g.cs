
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCacheControlTtl
    {
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCacheControlTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCacheControlTtl value)
        {
            return value switch
            {
                AnthropicCacheControlTtl.x1h => "1h",
                AnthropicCacheControlTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCacheControlTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => AnthropicCacheControlTtl.x1h,
                "5m" => AnthropicCacheControlTtl.x5m,
                _ => null,
            };
        }
    }
}