
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The service tier this request was routed to (e.g. flex, priority). The tier actually applied and billed is determined by the provider response and may differ.
    /// </summary>
    public enum ProviderResponseRoutedServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResponseRoutedServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResponseRoutedServiceTier value)
        {
            return value switch
            {
                ProviderResponseRoutedServiceTier.Flex => "flex",
                ProviderResponseRoutedServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResponseRoutedServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "flex" => ProviderResponseRoutedServiceTier.Flex,
                "priority" => ProviderResponseRoutedServiceTier.Priority,
                _ => null,
            };
        }
    }
}