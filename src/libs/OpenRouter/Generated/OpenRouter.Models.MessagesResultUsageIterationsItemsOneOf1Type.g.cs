
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesResultUsageIterationsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResultUsageIterationsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResultUsageIterationsItemsOneOf1Type value)
        {
            return value switch
            {
                MessagesResultUsageIterationsItemsOneOf1Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResultUsageIterationsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessagesResultUsageIterationsItemsOneOf1Type.Message,
                _ => null,
            };
        }
    }
}