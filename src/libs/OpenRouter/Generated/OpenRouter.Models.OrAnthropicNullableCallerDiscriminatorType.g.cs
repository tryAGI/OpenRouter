
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrAnthropicNullableCallerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250825,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20260120,
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrAnthropicNullableCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrAnthropicNullableCallerDiscriminatorType value)
        {
            return value switch
            {
                OrAnthropicNullableCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                OrAnthropicNullableCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                OrAnthropicNullableCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrAnthropicNullableCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => OrAnthropicNullableCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => OrAnthropicNullableCallerDiscriminatorType.CodeExecution20260120,
                "direct" => OrAnthropicNullableCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}