
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: context-compression
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant3Id
    {
        /// <summary>
        /// context-compression
        /// </summary>
        ContextCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant3IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant3Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant3Id.ContextCompression => "context-compression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant3Id? ToEnum(string value)
        {
            return value switch
            {
                "context-compression" => ResponsesRequestPluginsItemsVariant3Id.ContextCompression,
                _ => null,
            };
        }
    }
}