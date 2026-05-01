
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputMessageItemContentItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemContentItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemContentItemsOneOf1Type value)
        {
            return value switch
            {
                InputMessageItemContentItemsOneOf1Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemContentItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => InputMessageItemContentItemsOneOf1Type.InputImage,
                _ => null,
            };
        }
    }
}