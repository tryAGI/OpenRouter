
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecution20250825CallerType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250825,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecution20250825CallerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecution20250825CallerType value)
        {
            return value switch
            {
                AnthropicCodeExecution20250825CallerType.CodeExecution20250825 => "code_execution_20250825",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecution20250825CallerType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => AnthropicCodeExecution20250825CallerType.CodeExecution20250825,
                _ => null,
            };
        }
    }
}