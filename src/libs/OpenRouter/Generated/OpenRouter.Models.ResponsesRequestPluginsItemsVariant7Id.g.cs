
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: response-healing
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant7Id
    {
        /// <summary>
        /// response-healing
        /// </summary>
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant7IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant7Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant7Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant7Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => ResponsesRequestPluginsItemsVariant7Id.ResponseHealing,
                _ => null,
            };
        }
    }
}