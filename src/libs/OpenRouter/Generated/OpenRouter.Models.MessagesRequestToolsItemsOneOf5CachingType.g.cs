
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf5CachingType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf5CachingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf5CachingType value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf5CachingType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf5CachingType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesRequestToolsItemsOneOf5CachingType.Ephemeral,
                _ => null,
            };
        }
    }
}