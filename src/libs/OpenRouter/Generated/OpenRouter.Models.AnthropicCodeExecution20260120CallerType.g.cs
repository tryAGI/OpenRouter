
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecution20260120CallerType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20260120,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecution20260120CallerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecution20260120CallerType value)
        {
            return value switch
            {
                AnthropicCodeExecution20260120CallerType.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecution20260120CallerType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20260120" => AnthropicCodeExecution20260120CallerType.CodeExecution20260120,
                _ => null,
            };
        }
    }
}