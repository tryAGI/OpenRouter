
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputCodeInterpreterServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_codeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCodeInterpreterServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCodeInterpreterServerToolItemType value)
        {
            return value switch
            {
                OutputCodeInterpreterServerToolItemType.Openrouter_codeInterpreter => "openrouter:code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCodeInterpreterServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:code_interpreter" => OutputCodeInterpreterServerToolItemType.Openrouter_codeInterpreter,
                _ => null,
            };
        }
    }
}