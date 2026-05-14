
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicAllowedCallersItems
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
    public static class AnthropicAllowedCallersItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicAllowedCallersItems value)
        {
            return value switch
            {
                AnthropicAllowedCallersItems.CodeExecution20250825 => "code_execution_20250825",
                AnthropicAllowedCallersItems.CodeExecution20260120 => "code_execution_20260120",
                AnthropicAllowedCallersItems.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicAllowedCallersItems? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => AnthropicAllowedCallersItems.CodeExecution20250825,
                "code_execution_20260120" => AnthropicAllowedCallersItems.CodeExecution20260120,
                "direct" => AnthropicAllowedCallersItems.Direct,
                _ => null,
            };
        }
    }
}