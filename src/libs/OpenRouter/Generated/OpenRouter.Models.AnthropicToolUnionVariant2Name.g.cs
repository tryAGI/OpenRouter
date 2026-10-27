
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant2Name
    {
        /// <summary>
        ///
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant2NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant2Name value)
        {
            return value switch
            {
                AnthropicToolUnionVariant2Name.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant2Name? ToEnum(string value)
        {
            return value switch
            {
                "bash" => AnthropicToolUnionVariant2Name.Bash,
                _ => null,
            };
        }
    }
}