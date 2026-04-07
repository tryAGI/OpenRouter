
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicEncryptedCodeExecutionResultType
    {
        /// <summary>
        /// 
        /// </summary>
        EncryptedCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicEncryptedCodeExecutionResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicEncryptedCodeExecutionResultType value)
        {
            return value switch
            {
                AnthropicEncryptedCodeExecutionResultType.EncryptedCodeExecutionResult => "encrypted_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicEncryptedCodeExecutionResultType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_code_execution_result" => AnthropicEncryptedCodeExecutionResultType.EncryptedCodeExecutionResult,
                _ => null,
            };
        }
    }
}