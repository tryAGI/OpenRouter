
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: code_execution_20260120
    /// </summary>
    public enum OrAnthropicNullableCallerVariant2Type
    {
        /// <summary>
        /// code_execution_20260120
        /// </summary>
        CodeExecution20260120,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrAnthropicNullableCallerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrAnthropicNullableCallerVariant2Type value)
        {
            return value switch
            {
                OrAnthropicNullableCallerVariant2Type.CodeExecution20260120 => "code_execution_20260120",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrAnthropicNullableCallerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20260120" => OrAnthropicNullableCallerVariant2Type.CodeExecution20260120,
                _ => null,
            };
        }
    }
}