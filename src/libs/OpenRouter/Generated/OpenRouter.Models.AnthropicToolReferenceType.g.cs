
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolReferenceType value)
        {
            return value switch
            {
                AnthropicToolReferenceType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "tool_reference" => AnthropicToolReferenceType.ToolReference,
                _ => null,
            };
        }
    }
}