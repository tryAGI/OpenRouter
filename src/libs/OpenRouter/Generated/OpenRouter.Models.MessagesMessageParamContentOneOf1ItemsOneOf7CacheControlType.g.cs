
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlType.Ephemeral,
                _ => null,
            };
        }
    }
}