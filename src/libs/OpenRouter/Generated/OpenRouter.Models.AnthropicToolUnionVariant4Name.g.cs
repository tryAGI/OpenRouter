
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant4Name
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant4NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant4Name value)
        {
            return value switch
            {
                AnthropicToolUnionVariant4Name.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant4Name? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => AnthropicToolUnionVariant4Name.WebSearch,
                _ => null,
            };
        }
    }
}