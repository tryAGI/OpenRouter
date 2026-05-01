
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessageContentOneOf0ItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageContentOneOf0ItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageContentOneOf0ItemsOneOf1Type value)
        {
            return value switch
            {
                EasyInputMessageContentOneOf0ItemsOneOf1Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageContentOneOf0ItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => EasyInputMessageContentOneOf0ItemsOneOf1Type.InputImage,
                _ => null,
            };
        }
    }
}