
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf5Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf5Type.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf5Type? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => MessagesMessageParamContentOneOf1ItemsOneOf5Type.Thinking,
                _ => null,
            };
        }
    }
}