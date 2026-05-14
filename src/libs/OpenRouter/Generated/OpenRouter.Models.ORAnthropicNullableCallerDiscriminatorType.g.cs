
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ORAnthropicNullableCallerDiscriminatorType
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
    public static class ORAnthropicNullableCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicNullableCallerDiscriminatorType value)
        {
            return value switch
            {
                ORAnthropicNullableCallerDiscriminatorType.CodeExecution20250825 => "code_execution_20250825",
                ORAnthropicNullableCallerDiscriminatorType.CodeExecution20260120 => "code_execution_20260120",
                ORAnthropicNullableCallerDiscriminatorType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicNullableCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => ORAnthropicNullableCallerDiscriminatorType.CodeExecution20250825,
                "code_execution_20260120" => ORAnthropicNullableCallerDiscriminatorType.CodeExecution20260120,
                "direct" => ORAnthropicNullableCallerDiscriminatorType.Direct,
                _ => null,
            };
        }
    }
}