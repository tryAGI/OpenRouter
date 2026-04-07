
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicServiceTier value)
        {
            return value switch
            {
                AnthropicServiceTier.Batch => "batch",
                AnthropicServiceTier.Priority => "priority",
                AnthropicServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "batch" => AnthropicServiceTier.Batch,
                "priority" => AnthropicServiceTier.Priority,
                "standard" => AnthropicServiceTier.Standard,
                _ => null,
            };
        }
    }
}