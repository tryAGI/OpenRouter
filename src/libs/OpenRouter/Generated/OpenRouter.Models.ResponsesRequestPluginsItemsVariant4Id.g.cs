
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: fusion
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant4Id
    {
        /// <summary>
        /// fusion
        /// </summary>
        Fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant4IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant4Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant4Id.Fusion => "fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant4Id? ToEnum(string value)
        {
            return value switch
            {
                "fusion" => ResponsesRequestPluginsItemsVariant4Id.Fusion,
                _ => null,
            };
        }
    }
}