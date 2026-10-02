
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemCodeInterpreterCallType
    {
        /// <summary>
        ///
        /// </summary>
        CodeInterpreterCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemCodeInterpreterCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemCodeInterpreterCallType value)
        {
            return value switch
            {
                OutputItemCodeInterpreterCallType.CodeInterpreterCall => "code_interpreter_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemCodeInterpreterCallType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => OutputItemCodeInterpreterCallType.CodeInterpreterCall,
                _ => null,
            };
        }
    }
}