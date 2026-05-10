
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecutionContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionResult,
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResultError,
        /// <summary>
        /// 
        /// </summary>
        EncryptedCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecutionContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecutionContentDiscriminatorType value)
        {
            return value switch
            {
                AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionResult => "code_execution_result",
                AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionToolResultError => "code_execution_tool_result_error",
                AnthropicCodeExecutionContentDiscriminatorType.EncryptedCodeExecutionResult => "encrypted_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecutionContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_result" => AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionResult,
                "code_execution_tool_result_error" => AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionToolResultError,
                "encrypted_code_execution_result" => AnthropicCodeExecutionContentDiscriminatorType.EncryptedCodeExecutionResult,
                _ => null,
            };
        }
    }
}