
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: code_execution_20250825
    /// </summary>
    public enum AnthropicCallerVariant1Type
    {
        /// <summary>
        /// code_execution_20250825
        /// </summary>
        CodeExecution20250825,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCallerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCallerVariant1Type value)
        {
            return value switch
            {
                AnthropicCallerVariant1Type.CodeExecution20250825 => "code_execution_20250825",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCallerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => AnthropicCallerVariant1Type.CodeExecution20250825,
                _ => null,
            };
        }
    }
}