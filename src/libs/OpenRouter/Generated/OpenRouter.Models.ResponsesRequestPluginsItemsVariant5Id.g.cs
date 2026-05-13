
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: moderation
    /// </summary>
    public enum ResponsesRequestPluginsItemsVariant5Id
    {
        /// <summary>
        /// moderation
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsVariant5IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsVariant5Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsVariant5Id.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsVariant5Id? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ResponsesRequestPluginsItemsVariant5Id.Moderation,
                _ => null,
            };
        }
    }
}