
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputCodeInterpreterCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreterCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCodeInterpreterCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCodeInterpreterCallItemType value)
        {
            return value switch
            {
                OutputCodeInterpreterCallItemType.CodeInterpreterCall => "code_interpreter_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCodeInterpreterCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => OutputCodeInterpreterCallItemType.CodeInterpreterCall,
                _ => null,
            };
        }
    }
}