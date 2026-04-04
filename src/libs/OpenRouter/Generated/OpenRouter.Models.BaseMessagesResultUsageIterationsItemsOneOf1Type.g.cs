
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultUsageIterationsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultUsageIterationsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultUsageIterationsItemsOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultUsageIterationsItemsOneOf1Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultUsageIterationsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => BaseMessagesResultUsageIterationsItemsOneOf1Type.Message,
                _ => null,
            };
        }
    }
}