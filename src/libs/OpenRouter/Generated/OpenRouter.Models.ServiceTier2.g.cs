
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTier2 value)
        {
            return value switch
            {
                ServiceTier2.Auto => "auto",
                ServiceTier2.Default => "default",
                ServiceTier2.Flex => "flex",
                ServiceTier2.Priority => "priority",
                ServiceTier2.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTier2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTier2.Auto,
                "default" => ServiceTier2.Default,
                "flex" => ServiceTier2.Flex,
                "priority" => ServiceTier2.Priority,
                "scale" => ServiceTier2.Scale,
                _ => null,
            };
        }
    }
}