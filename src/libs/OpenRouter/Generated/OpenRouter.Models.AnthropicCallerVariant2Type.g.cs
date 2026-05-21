
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: code_execution_20260120
    /// </summary>
    public enum AnthropicCallerVariant2Type
    {
        /// <summary>
        /// code_execution_20260120
        /// </summary>
        CodeExecution20260120,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCallerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCallerVariant2Type value)
        {
            return value switch
            {
                AnthropicCallerVariant2Type.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCallerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20260120" => AnthropicCallerVariant2Type.CodeExecution20260120,
                _ => null,
            };
        }
    }
}