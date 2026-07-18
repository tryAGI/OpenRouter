
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentMessageItemContentItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentMessageItemContentItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMessageItemContentItemsOneOf1Type value)
        {
            return value switch
            {
                AgentMessageItemContentItemsOneOf1Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMessageItemContentItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => AgentMessageItemContentItemsOneOf1Type.InputImage,
                _ => null,
            };
        }
    }
}