
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeInterpreterCallItemOutputsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterCallItemOutputsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterCallItemOutputsItemsOneOf0Type value)
        {
            return value switch
            {
                CodeInterpreterCallItemOutputsItemsOneOf0Type.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterCallItemOutputsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "image" => CodeInterpreterCallItemOutputsItemsOneOf0Type.Image,
                _ => null,
            };
        }
    }
}