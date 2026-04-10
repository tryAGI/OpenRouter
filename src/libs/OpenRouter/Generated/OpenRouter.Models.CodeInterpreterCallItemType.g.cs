
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeInterpreterCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreterCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterCallItemType value)
        {
            return value switch
            {
                CodeInterpreterCallItemType.CodeInterpreterCall => "code_interpreter_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => CodeInterpreterCallItemType.CodeInterpreterCall,
                _ => null,
            };
        }
    }
}