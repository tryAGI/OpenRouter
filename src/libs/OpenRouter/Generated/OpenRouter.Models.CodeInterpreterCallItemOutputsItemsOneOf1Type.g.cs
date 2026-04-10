
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeInterpreterCallItemOutputsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterCallItemOutputsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterCallItemOutputsItemsOneOf1Type value)
        {
            return value switch
            {
                CodeInterpreterCallItemOutputsItemsOneOf1Type.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterCallItemOutputsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "logs" => CodeInterpreterCallItemOutputsItemsOneOf1Type.Logs,
                _ => null,
            };
        }
    }
}